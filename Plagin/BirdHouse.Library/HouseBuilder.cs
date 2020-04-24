using Kompas6API5;
using Kompas6Constants;
using Kompas6Constants3D;
using System;

namespace BirdHouse.Library
{
    public class HouseBuilder
    {

        /// <summary>
        /// Интерфейс компонента
        /// </summary>
        public ksPart iPart;

        /// <summary>
        /// Построить скворечник
        /// </summary>
        public void Build(ksPart iPart, KompasObject kompas, HouseParameters houseParameters)
        {
            this.iPart = iPart;
            CreateMain(iPart, kompas, houseParameters);
        }

        /// <summary>
        /// Функция выполняет построение 
        /// </summary>
        public void CreateMain(ksPart iPart, KompasObject kompas, HouseParameters houseParameters)
        {
            int thickness = houseParameters.Depth;
            ksEntity iSketch;
            ksSketchDefinition iDefinitionSketch;

            CreateSketch(out iSketch, out iDefinitionSketch);
            // Интерфейс для рисования = на скетче;
            ksDocument2D iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();
            // Построить прямоугольник (x1,y1, x2,y2, style)
            ksRectangleParam part1 = (ksRectangleParam)kompas.GetParamStruct((short)StructType2DEnum.ko_RectangleParam);
            part1.ang = 0; //Угол ?
            part1.x = 10;
            part1.y = 10;
            part1.width = houseParameters.Width;
            part1.height = houseParameters.Height; 
            part1.style = 1; // При нуле не видно деталь.
            iDocument2D.ksRectangle(part1);

            // Закончить редактировать эскиз
            iDefinitionSketch.EndEdit();

            ExctrusionSketch(iPart, iSketch, thickness, true);
        }


        /// <summary>
        /// Создать эскиз
        /// </summary>
        private void CreateSketch(out ksEntity iSketch, out ksSketchDefinition iDefinitionSketch, double offset = 0)
        {
            #region Создание смещенную плоскость -------------------------
            // интерфейс смещенной плоскости
            ksEntity iPlane = (ksEntity)iPart.NewEntity((short)Obj3dType.o3d_planeOffset);

            // Получаем интрефейс настроек смещенной плоскости
            ksPlaneOffsetDefinition iPlaneDefinition = (ksPlaneOffsetDefinition)iPlane.GetDefinition();

            // Настройки : начальная позиция, направление смещения, расстояние от плоскости, принять все настройки (create)
            iPlaneDefinition.SetPlane(iPart.GetDefaultEntity((short)Obj3dType.o3d_planeXOZ));
            iPlaneDefinition.direction = true;
            iPlaneDefinition.offset = offset;
            iPlane.Create();
            #endregion --------------------------------------------------

            // Создаем обьект эскиза
            iSketch = (ksEntity)iPart.NewEntity((short)Obj3dType.o3d_sketch);

            // Получаем интерфейс настроек эскиза
            iDefinitionSketch = iSketch.GetDefinition();

            // Устанавливаем плоскость эскиза
            iDefinitionSketch.SetPlane(iPlane);

            // Теперь когда св-ва эскиза установлены можно его создать 
            iSketch.Create();
        }
        // <summary>
        /// Выдавливание по эскизу
        /// </summary>
        private void ExctrusionSketch(ksPart iPart, ksEntity iSketch, int dd, bool direction)
        {
            //Операция выдавливание
            ksEntity entityExtr = (ksEntity)iPart.NewEntity((short)Obj3dType.o3d_bossExtrusion);

            //Интерфейс операции выдавливания
            ksBossExtrusionDefinition extrusionDef = (ksBossExtrusionDefinition)entityExtr.GetDefinition();

            //Интерфейс структуры параметров выдавливания
            ksExtrusionParam extrProp = (ksExtrusionParam)extrusionDef.ExtrusionParam();

            //Эскиз операции выдавливания
            extrusionDef.SetSketch(iSketch);

            //Направление выдавливания
            if (direction == false)
            {
                extrProp.direction = (short)Direction_Type.dtReverse;
            }
            else
            {
                extrProp.direction = (short)Direction_Type.dtNormal;
            }

            //Тип выдавливания
            extrProp.typeNormal = (short)End_Type.etBlind;

            //Глубина выдавливания
            if (direction == false)
            {
                extrProp.depthReverse = dd;
            }
            else
            {
                extrProp.depthNormal = dd;
            }
            //Создание операции выдавливания
            entityExtr.Create();
        }


    }

}

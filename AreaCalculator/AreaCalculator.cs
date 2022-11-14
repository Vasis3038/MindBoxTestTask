﻿using AreaCalculator.Shapes;

namespace AreaCalculator;

/*Напишите на C# библиотеку для поставки внешним клиентам, 
которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. 

Дополнительно к работоспособности оценим:

Юнит-тесты

Легкость добавления других фигур

Вычисление площади фигуры без знания типа фигуры в compile-time

Проверку на то, является ли треугольник прямоугольным */

public static class AreaCalculator
{
    public static double CalculateArea(IAreaCountable shape)
    {
        return shape.CountArea();
    }
}

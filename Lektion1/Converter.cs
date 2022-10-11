using System;
namespace MathConverter;

public class Converter
{
	public double RadiansToDegrees(double radian)
	{
		return (Math.PI / 180) * radian;
	}

	public double DegreesToRadians(double degree)
	{
		return (180 / Math.PI) * degree;
	}
}

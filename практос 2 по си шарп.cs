using System;

public class Rectangle
{
	// Параметры прямоугольника
	private double width;
	private double height;

	// Конструктор по умолчанию
	public Rectangle()
	{
		width = 1.0;
		height = 1.0;
	}

	// Конструктор с параметрами
	public Rectangle(double width, double height)
	{
		this.width = width;
		this.height = height;
	}

	// Метод для вычисления площади
	public double Area()
	{
		return width * height;
	}

	// Свойства для получения и установки ширины и высоты
	public double Width
	{
		get { return width; }
		set { width = value; }
	}

	public double Height
	{
		get { return height; }
		set { height = value; }
	}
}

// Пример использования класса
class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Введите ширину прямоугольника:");
		double width = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine("Введите высоту прямоугольника:");
		double height = Convert.ToDouble(Console.ReadLine());

		Rectangle rect = new Rectangle(width, height);
		Console.WriteLine($"Площадь прямоугольника: {rect.Area()}");
	}
}
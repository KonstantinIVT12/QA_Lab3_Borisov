namespace TriangleTest
{
    /// <summary>
    /// Класс, представляющий треугольник
    /// </summary>
    class Triangle
    {   /// <summary>
        /// Координаты вершин
        /// </summary>
        public double ax, bx, cx, ay, by, cy;

        /// <summary>
        /// Название объекта
        /// </summary>

        public string Name;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Triangle() : this(0, 0, 0, 0, 0, 0) { }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="_ax">Координата ax</param>
        /// <param name="_bx">Координата bx</param>
        /// <param name="_cx">Координата cx</param>
        /// <param name="_ay">Координата ay</param>
        /// <param name="_by">Координата by</param>
        /// <param name="_cy">Координата cy</param>
        /// Картинка для примера:
        /// </summary>
        /// <img src="x:\example.png" alt="Interval" width="400" height="300" />

        public Triangle(double _ax, double _bx, double _cx, double _ay, double _by, double _cy)
        {
            ax = _ax;
            bx = _bx;
            cx = _cx;
            ay = _ay;
            by = _by;
            cy = _cy;
        }

        /// <summary>
        /// Метод инициализации треугольника с новыми значениями
        /// </summary>
        /// <param name="_ax">Координата ax</param>
        /// <param name="_bx">Координата bx</param>
        /// <param name="_cx">Координата cx</param>
        /// <param name="_ay">Координата ay</param>
        /// <param name="_by">Координата by</param>
        /// <param name="_cy">Координата cy</param>
        public void Init(double _ax, double _bx, double _cx, double _ay, double _by, double _cy)
        {
            ax = _ax;
            bx = _bx;
            cx = _cx;
            ay = _ay;
            by = _by;
            cy = _cy;
        }

        /// <summary>
        /// Метод чтения значений для треугольника с консоли
        /// </summary>
        public void Read()
        {
            Console.Write("Введите ax: ");
            ax = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ay: ");
            ay = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите bx: ");
            bx = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите by: ");
            by = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите cx: ");
            cx = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите cy: ");
            cy = Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// Метод вывода информации об треугольнике
        /// </summary>
        public void Display()
        {
            Console.WriteLine($"a = ({ax}, {ay}), b = ({bx}, {by}), c = ({cx}, {cy})");
        }

        /// <summary>
        /// Метод вычисления расстояния от центра треугольника до начала координат
        /// </summary>
        /// <returns>Расстояние до начала координат</returns>
        public double Distance()
        {
            // Вычисляем центр треугольника
            double centerX = (ax + bx + cx) / 3.0;
            double centerY = (ay + by + cy) / 3.0;

            // Вычисляем расстояние от центра до начала координат
            double distanceToOrigin = Math.Sqrt(centerX * centerX + centerY * centerY);

            return distanceToOrigin;
        }

        /// <summary>
        /// Виртуальный Метод присваивания значений треугольника для пирамиды.
        /// Присваивает значения координат текущей пирамиде из другого треугольника.
        /// </summary>
        /// <param name="p">Треугольник, значения которого будут присвоены пирамиде.</param>
        public virtual void Assign(Triangle p)
        {
            ax = p.ax; // Присваивание координаты ax текущего треугольника из другого треугольника.
            ay = p.ay; // Присваивание координаты ay текущего треугольника из другого треугольника.
            bx = p.bx; // Присваивание координаты bx текущего треугольника из другого треугольника.
            by = p.by; // Присваивание координаты by текущего треугольника из другого треугольника.
            cx = p.cx; // Присваивание координаты cx текущего треугольника из другого треугольника.
            cy = p.cy; // Присваивание координаты cy текущего треугольника из другого треугольника.
        }

        /// <summary>
        /// Статический метод для сложения величин двух треугольников
        /// </summary>
        /// <param name="p">Первый треугольник</param>
        /// <param name="p1">Второй треугольник</param>
        /// <returns>Результат сложения</returns>

        public static Triangle Add(Triangle p, Triangle p1)
        {
            Triangle res = new Triangle();
            res.ax = p.ax + p1.ax;
            res.ay = p.ay + p1.ay;
            res.bx = p.bx + p1.bx;
            res.by = p.by + p1.by;
            res.cx = p.cx + p1.cx;
            res.cy = p.cy + p1.cy;
            return res;
        }
    }

    /// <summary>
    /// Класс, представляющий пирамиду
    /// </summary>
    class Pyramid : Triangle
    {
        /// <summary>
        /// Дополнительное поле - высота пирамиды
        /// </summary>
        private double z;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Pyramid() : base(0, 0, 0, 0, 0, 0)
        {
            z = 0;
        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="_ax">Координата ax центра треугольника</param>
        /// <param name="_ay">Координата ay центра треугольника</param>
        /// <param name="_bx">Координата bx центра треугольника</param>
        /// <param name="_by">Координата by центра треугольника</param>
        /// <param name="_cx">Координата cx центра треугольника</param>
        /// <param name="_cy">Координата cy центра треугольника</param>
        /// <param name="_z">Высота пирамиды</param>
        public Pyramid(double _ax, double _ay, double _bx, double _by, double _cx, double _cy, double _z) : base(_ax, _ay, _bx, _by, _cx, _cy)
        {
            z = _z;
        }
    
    /// <summary>
    /// Метод установки значения высоты пирамиды
    /// </summary>
    /// <param name="_z">Высота пирамиды</param>
    public void Put(double _z)
        {
            z = _z;
        }

        /// <summary>
        /// Метод получения значения высоты пирамиды
        /// </summary>
        /// <returns>Высота пирамиды</returns>
        public double Get()
        {
            return z;
        }

        /// <summary>
        /// Переопределение метода инициализации для пирамиды
        /// </summary>
        /// <param name="_ax">Координата ax центра треугольника</param>
        /// <param name="_ay">Координата ay центра треугольника</param>
        /// <param name="_bx">Координата bx центра треугольника</param>
        /// <param name="_by">Координата by центра треугольника</param>
        /// <param name="_cx">Координата cx центра треугольника</param>
        /// <param name="_cy">Координата cy центра треугольника</param>
        /// <param name="_z">Высота цилиндра</param>
        public void Init(double _ax, double _ay, double _bx, double _by, double _cx, double _cy, double _z)
        {
            base.Init(_ax, _ay, _bx, _by, _cx, _cy); // Вызов метода инициализации базового класса
            z = _z;
        }

        /// <summary>
        /// Переопределение метода отображения информации о пирамиде
        /// </summary>
        public new void Display()
        {
            base.Display(); // Вызов метода отображения базового класса
            Console.WriteLine($"z = {z}");
        }

        /// <summary>
        /// Переопределение метода присваивания значений треугольника для пирамиды
        /// </summary>
        /// <param name="p">Треугольник, значения которой будут присвоены пирамиде</param>
        public override void Assign(Triangle p)
        {
            base.Assign(p); // Вызов метода присваивания базового класса
            z = z * 2; // Высота пирамиды удваивается
        }
    }

    /// <summary>
    /// Основной класс программы
    /// </summary>
    /// Формулы площади треугольника: 
    /// \f[
    /// S = (a*h)/2
    /// \f]
    /// Формула для нахождения центра масс (барицентра) треугольника по координатам вершин:
    /// \f[
    /// (x_c, y_c) = ( (x_1 + x_2 + x_3) / 3, (y_1 + y_2 + y_3) / 3 )
    /// \f]
    /// Периметр треугольника:
    /// \f[
    /// P=a+b+c
    /// \f]
    /// <remarks>
    /// Этот класс содержит точку входа в программу и демонстрирует
    /// использование классов Triangle и Pyramid для работы с треугольниками 
    /// </remarks>

    class Program
    {
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <param name="args">Аргументы командной строки</param>
        static void Main()
        {
            Triangle c = new Triangle(); // Создание треугольника
            Triangle c2 = new Triangle(); // Создание второго треугольника
            Triangle c3 = new Triangle(); // Создание третьего треугольника
            Triangle c1 = new Triangle(); // Создание четвертого треугольника

            Console.WriteLine("Название объекта: Треугольники");

            Console.WriteLine("Введите параметры для треугольника 1: ");
            c1.Read();

            Console.WriteLine("Введите параметры для треугольника 2: ");
            c2.Read();

            c3 = Triangle.Add(c2, c1); // Сложение двух треугольников

            Console.WriteLine("Расстояние от центра треугольника 1 до начала координат: " + c1.Distance());
            Console.WriteLine("Расстояние от центра треугольника 2 до начала координат: " + c2.Distance());
            Console.WriteLine("Сумма треугольников 1 и 2: ");
            c3.Display(); // Отображение результатов сложения треугольников
                          // Создаем объекты базового и производного классов
            Triangle c0 = new Triangle(); // Создание объекта треугольника
            Pyramid pyramid = new Pyramid(1.0, 2.0, 3.0, 4.0, 1.0, 2.0, 3.0); // Создание объекта пирамиды

            // Инициализируем объект базового класса
            c0.Init(1.0, 2.0, 3.0, 1.0, 2.0, 3.0);

            // Присваиваем объекту производного класса объект базового класса
            pyramid.Assign(c0);

            // Выводим информацию о пирамиде
            pyramid.Display();

            // Демонстрируем работу с методами Get и Put для поля z
            Console.WriteLine($"Значение поля z: {pyramid.Get()}");
            pyramid.Put(5.0);
            Console.WriteLine($"Новое значение поля z: {pyramid.Get()}");

        }
    }
}
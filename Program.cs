using System;

// Xây dựng lớp ngoại lệ tùy chỉnh khi biểu thức dưới căn < 0
class NotNegativeException : Exception
{
    public NotNegativeException(string message) : base(message) { }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Nhap x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Nhap y: ");
            double y = double.Parse(Console.ReadLine());

            // Kiểm tra điều kiện dưới căn
            double innerSqrt = 3 * x + 2 * y;
            if (innerSqrt < 0)
            {
                throw new NotNegativeException("Loi: Bieu thuc duoi dau can nho hon 0!");
            }

            // Kiểm tra mẫu số
            double denominator = 2 * x - y;
            if (denominator == 0)
            {
                throw new DivideByZeroException("Loi: Mau so (2x - y) bang 0!");
            }

            double h = Math.Sqrt(innerSqrt) / denominator;
            Console.WriteLine($"Ket qua H = {h}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Loi: Ban phai nhap vao mot so nguyen/so thuc hop le!");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (NotNegativeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Da xay ra loi khong xac dinh: {ex.Message}");
        }
    }
}
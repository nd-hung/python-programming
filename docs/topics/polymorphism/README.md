# Đa hình

Polymorphism

---

## Dẫn nhập

Giả sử cần viết ứng dụng quản lý một danh sách động vật gồm nhiều loài khác nhau (chó, mèo, dê, gà, cừu ...). Với mỗi loài đều cần có hành động phát ra tiếng kêu, tuy nhiên cách thức phát ra tiếng kêu của mỗi loài lại khác nhau.

Câu hỏi: Có thể cài đặt phương thức giống nhau `Speak()` sao cho khi thêm một con vật mới vào danh sách, tùy theo nó thuộc loài nào mà phương thức `Speak()` sẽ thực thi đoạn code phát ra tiếng kêu phù hợp?

Vấn đề này có thể giải quyết hiệu quả bằng kỹ thuật đa hình (polymorphism).

## Kỹ thuật đa hình

<center><img src="img/polymorphism-hierachy.png" width="75%"></center>

- Đa hình là một trong bốn đặc trưng quan trọng nhất của phương pháp lập trình hướng đối tượng (bao gồm: trừu tượng hóa (abstraction), bao đóng (encapsulation), thừa kế (inheritance) và đa hình (polymorphism)). Có hai loại đa hình: đa hình tĩnh ([nạp chồng phương thức](https://nd-hung.github.io/oop/topics/classes-and-objects/#nap-chong-phuong-thuc-method-overloading), [nạp chồng toán tử](https://nd-hung.github.io/oop/topics/classes-and-objects/#nap-chong-toan-tu-operator-overloading)) và đa hình động (ghi đè phương thức).
- Cơ chế đa hình động xuất hiện khi có quan hệ thừa kế.

- Hai đặc điểm mấu chốt của đa hình động:
    - Tại thời điểm chạy ứng dụng, các đối tượng của lớp con có thể được xử lý như là đối tượng của lớp cha. Nói cách khác, một đối tượng của lớp cha có thể giữ một đối tượng của lớp con và gọi phương thức của lớp con đó. Khi đó, kiểu dữ liệu của đối tượng lúc khai báo và lúc thực thi chương trình là khác nhau.
    - Ở lớp cơ sở có thể cài đặt các phương thức ảo (virtual methods), ở các lớp dẫn xuất sẽ cài đặt các phương thức ghi đè (override methods). Khi chạy ứng dụng, trình điều khiển thực thi CLR (Common Language Runtime) sẽ gọi phương thức ghi đè của lớp con.

Cơ chế đa hình cho phép cài đặt một cách nhất quán các phương thức giống nhau của các lớp đối tượng khác nhau thông qua hai bước sau:

1. Tạo một lớp cơ sở chung của các loại đối tượng có liên quan với nhau. Sau đó cài đặt từng lớp dẫn xuất phù hợp với loại đối tượng cụ thể. Ở lớp cơ sở tạo phương thức ảo (virtual method), ở lớp dẫn xuất tạo phương thức ghi đè (override method).

2. Từ đối tượng của lớp cơ sở sử dụng phương thức ảo để gọi phương thức ghi đè ở lớp dẫn xuất.

## Ví dụ 1

![Polymorphism](img/Polymorphism.png)

Với bài toán quản lý động vật ở trên, ta cần xây dựng lớp cơ sở Animal với phương thức ảo (virtual method) có tên
`Speak()`. Sau đó, trong mỗi lớp dẫn xuất đến lớp Animal đều cài đặt phương thức trùng tên và ghi đè (override) lên phương thức của lớp cơ sở.

```c#
// Tạo lớp cơ sở Animal mô quả động vật tổng quát
public class Animal
{
    public string Name;

    // Constructor
    public Animal(string name = "")
    {
        Name = name;
    }
    // Tạo phương thức ảo (virtual) phát ra tiếng kêu
    public virtual void Speak()
    {
        Console.WriteLine("Hello, I'm an animal.");
    }
}

// Tạo lớp dẫn xuất Dog kế thừa lớp Animal
public class Dog : Animal
{
    // Constructor
    public Dog(string name = "") : base(name) { }
    // Tạo phương thức ghi đè (override) phát ra tiếng kêu của loài chó
    public override void Speak()
    {
        Console.WriteLine("Wufwuf, I'm a dog. My name is " + Name);
    }
}

// Tạo lớp dẫn xuất Cat kế thừa lớp Animal
public class Cat : Animal
{
    // Constructor
    public Cat(string name = "") : base(name) { }

    // Tạo phương thức ghi đè (override) phát ra tiếng kêu của loài mèo
    public override void Speak()
    {
        Console.WriteLine("Meow, I'm a cat. My name is " + Name);
    }
}

// Chương trình chính
public class DemoPolymorphism
{
    public static void Main()
    {
        // Tạo một danh sách loài vật
        var animals = new List<Animal>
        {
            new Dog("Shiba"),
            new Cat("Tom"),
            new Cat("Doreamon"),
            new Dog("Tyke")
        };

        // Gọi phương thức phát tiếng kêu của mỗi con vật
        foreach (var pet in animals)
        {
            pet.Speak();
        }
    }
}

/* Output
Wufwuf, I'm a dog. My name is Shiba
Meow, I'm a cat. My name is Tom
Meow, I'm a cat. My name is Doreamon
Wufwuf, I'm a dog. My name is Tyke
*/
```

Ta thấy, cơ chế đa hình không những hỗ trợ tái sử dụng mã nguồn triệt để mà còn giúp cài đặt một cách nhất quán các phương thức giống nhau về hành động nhưng khác nhau về cách thức. Hơn nữa, khi cần bổ sung một lớp dẫn xuất mới, chẳng hạn lớp Pig, thì không phải sửa đổi mã nguồn đã có.

## Ví dụ 2

Viết chương trình sao cho khi chạy cho phép tạo các hình khác nhau (vuông, tròn, tam giác,...), sau đó tìm hình vẽ có diện tích lớn nhất.

Cách giải quyết bài toán này tương tự [Ví dụ 1](https://nd-hung.github.io/oop/topics/polymorphism/#vi-du-1). Trước hết tạo lớp cơ sở Shape có phương thức ảo `GetArea()` để tính diện tích hình vẽ. Do Shape là lớp tổng quát, chưa biết hình vẽ cụ thể nên không tính được diện tích, vì thế ta cho kết quả trả về là `0`. Ở lớp dẫn xuất Circle có phương thức ghi đè `GetArea()`, ở đây đã biết loại hình vẽ cụ thể (hình tròn) nên tính được diện tích của nó. Tương tự như vậy với lớp dẫn xuất Rectangle (hình chữ nhật).

Trong chương trình chính tạo danh sách đối tượng thuộc lớp Shape nhưng khởi tạo thành 2 loại đối tượng khác nhau: 1 của lớp Circle và 1 của lớp Rectangle. Ta thấy, khi gọi phương thức tính diện tích của mỗi đối tượng, tùy theo kiểu của đối tượng cụ thể được tạo ra (hình tròn, hình chữ nhật) mà các dòng lệnh tính diện tích phù hợp được gọi.

![UML class diagram](img/Polymorphism-ClassDiagram.png)

([Xem trên GitHub](https://github.com/nd-hung/oop/tree/main/docs/topics/polymorphism/code/Shape/))

```c#
// Tạo lớp hình vẽ tổng quát (Shape)
public class Shape
{
    // Phương thức ảo tính diện tích
    // Shape không phải hình vẽ cụ thể, nên không tính được diện tích
    public virtual double GetArea()
    {
        return 0;
    }
}// Kết thúc lớp Shape

// Tạo lớp hình tròn (Circle) kế thừa lớp hình vẽ
public class Circle : Shape
{
    public double Radius;   // Thuộc tính lưu độ dài bán kính

    // Constructor
    public Circle(double r = 0)
    {
        Radius = r;
    }

    // Phương thức ghi đè (override) tính diện tích hình tròn
    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}// Kết thúc lớp Circle

// Lớp hình chữ nhật (Rectangle) kế thừa lớp hình vẽ
public class Rectangle : Shape
{
    public double Width;    // Các thuộc tính lưu kích thước hình chữ nhật
    public double Height;

    // Constructor
    public Rectangle(double w = 0, double h = 0)
    {
        Width = w;
        Height = h;
    }

    // Phương thức ghi đè tính diện tích hình chữ nhật
    public override double GetArea()
    {
        return Width * Height;
    }
} // Kết thúc lớp Rectangle

// Chương trình chính
class Program
{
    public static void Main()
    {
        // Tạo một danh dách các hình vẽ khác nhau
        var shapes = new List<Shape>
        {
            new Rectangle(9,6), // Hình chữ nhật (độ dài các cạnh)
            new Circle(1),      // Hình tròn (bán kính)
            new Circle(2.5),
            new Rectangle(6,9),
            new Circle(2.3)
        };

        // In thông tin của mỗi hình & tìm diện tích lớn nhất
        double maxArea = 0;
        foreach (var s in shapes)
        {
            Console.WriteLine("This is a {0}, area = {1:0.000}", s.GetType(), s.GetArea());
            if (s.GetArea() > maxArea) maxArea = s.GetArea();
        }

        // In thông tin (các) hình vẽ có diện tích lớn nhất
        Console.WriteLine("Cac hinh ve co dien tich lon nhat:");
        for (int i = 0; i < shapes.Count; i++)
            if (shapes[i].GetArea() == maxArea)
            {
                Console.WriteLine("Index = {0}, type: {1}, area = {2:0.000}", i, shapes[i].GetType(), shapes[i].GetArea());
            }
    }
}

/* Output
This is a Rectangle, area = 54.000
This is a Circle, area = 3.142
This is a Circle, area = 19.635
This is a Rectangle, area = 54.000
This is a Circle, area = 16.619
Cac hinh ve co dien tich lon nhat:
Index = 0, type: Rectangle, area = 54.000
Index = 3, type: Rectangle, area = 54.000
*/
```




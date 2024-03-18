# Lập trình hướng đối tượng với Python

Python OOP

---

## Các khái niệm cơ bản

- Lớp (class): Là cấu trúc dữ liệu mô tả các đối tượng giống nhau về tính chất (properties) và phương thức (methods).
- Đối tượng (object): là thực thể được tạo ra từ một lớp. Một lớp có thể tạo ra nhiều đối tượng khác nhau.

## Định nghĩa lớp

- Cú pháp

```python
class ClassName:
   <Các biến thành viên>
   <Các hàm thành viên>
```

## Phương thức `__init__()`

- Hàm thiết lập (constructor) của lớp Python có tên là `__init__()`.
- Hàm thiết lập được gọi mỗi khi đối tượng được tạo ra. Vì thế, thường dùng hàm này để khởi tạo các giá trị ban đầu cho đối tượng.
- Ví dụ:

```python
# Khai báo lớp học sinh
class Student:
    # Khai báo hàm khởi tạo
    def __init__(self, name, age):
        self.name = name
        self.age = age

    def PrintInfo(self):
        print('{}, {}'.format(self.name, self.age))

# Tạo đối tượng và khởi tạo giá trị
sv1 = Student("Trung", 18)
sv2 = Student('Thực', 19)
sv1.PrintInfo()
sv2.PrintInfo()
```

## Lớp bên trong lớp

- Ví dụ:

```python
# Minh họa cài đặt lớp bên trong lớp
# Lớp Laptop (outer class)
import datetime

class Laptop:
    # Phương thức khởi tạo của lớp ngoài
    def __init__(self, model, year=datetime.datetime.now().year, btr_voltage=None, btr_capacity=None):
        assert isinstance(year, int) and year > 0, 'Năm phải là số nguyên dương'
        self.Model = model  # model    
        self.Year = year    # năm sản xuất
        self.Battery = self.Battery(btr_voltage, btr_capacity)

    # Phương thức in thông tin của lớp ngoài
    def PrintInfo(self):
        print('Laptop model: {}, Year: {}'.format(self.Model, self.Year))
        # Gọi phương thức in thông tin của lớp trong
        self.Battery.PrintInfo()

    # Cài đặt lớp Battery (inner class) bên trong lớp Laptop
    class Battery:
        # Phương thức khởi tạo của lớp trong
        def __init__(self, volate, capacity):
            self.Voltage = volate       # Điện thế
            self.Capacity = capacity    # Dung lượng

        # Phương thức in thông tin của lớp trong
        def PrintInfo(self):
            print('Battery info: Voltage: {}, Capacity: {}'.format(self.Voltage, self.Capacity))

# Chương trình chính
if __name__ == '__main__':
    lap1 = Laptop('Dell', 2020, '12V', '55kWh')
    lap1.PrintInfo()
```

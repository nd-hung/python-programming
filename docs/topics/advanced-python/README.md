# Python nâng cao

Advanced Python

---

## Hàm Python

- Hàm là một đoạn mã nguồn được thiết kế để thực hiện một chức năng chuyên biệt.
- Hàm chỉ thực thi khi được gọi.
- Có thể gọi hàm nhiều lần với các đối số (dữ liệu vào) khác nhau.

- Có 3 loại hàm trong Python:
  - Hàm dựng sẵn (built-in functions). Ví dụ: abs(), range(), sorted(),...
  - Hàm định nghĩa trong các thư viện do bên thứ ba phát triển. Ví dụ: numpy.
  - Hàm do người dùng (lập trình viên) tự định nghĩa

### Các bước xây dựng hàm

- Để xây dựng một hàm, cần xác định các thành phần sau:
  - Tên hàm: Đặt theo quy tắc định danh của Python. Nên đặt tên hàm ngắn gọn, mô tả được chức năng của hàm.
  - Danh sách tham số: Là các dữ liệu đầu vào cho hàm xử lý.
  - Giá trị trả về: Kết quả trả về cho lời gọi hàm.
- Cú pháp

```python
def <Tên hàm>([<Tham số 1>, <Tham số 2>,...]):
    <Các lệnh>
    [return <Biểu thức>]
```

- Ví dụ
- Hàm in ra màn hình câu 'Hello world!'

```python
# Cài đặt hàm
def SayHi():
    print('Hello World!')

# Sử dụng hàm
SayHi()
```

- Hàm in ra màn hình một thông điệp tùy chọn:

```python
# Cài đặt hàm
def PrintMessage(msg):
    print(msg)

# Sử dụng hàm
msg1 = 'Hello World'
PrintMessage(msg1)

PrintMessage('I love Python')
```

- Hàm nhận vào 2 số nguyên, tính và in ra màn hình tổng của chúng:

```python
# Cài đặt hàm
def TinhTong(a, b):
    tong = a + b
    print(f'{a} + {b} = {tong}')

# Sử dụng hàm
x, y = 37, 21
a, b = 6, 9
TinhTong(x, y)
TinhTong(b, a)
```

- Hàm nhận vào 1 số tự nhiên, trả về `True` nếu là số nguyên tố:

```python
# Cài đặt hàm
def LaSNT(n):
    if n < 2: return False
    for i in range(2, n//2+1):
        if n%i ==0: return False
    return True
    
# Sử dụng hàm
print(LaSNT(8))
print(LaSNT(13))
```

## Hàm lambda

- Hàm lambda là dạng hàm không có tên, nhận vào một danh sách đối số và trả về một biểu thức.
- Cú pháp:

```python
lambda <DS tham số>:<Biểu thức>
```

- Ví dụ

```python
x = lambda a : a + 10
print(x(5))
y = lambda(a,b: a+b)
print(y(9, 6))
```

## Hàm map()

Hàm map() sẽ gọi hàm được chỉ ra với đối số là từng phần tử trong danh sách. Kết quả trả về (là đối tượng kiểu map) có thể chuyển thành danh sách qua hàm list(), hoặc tập hợp qua hàm set().

### Cú pháp

```python
map(function, iterables)
```

Trong đó, `function` là tên hàm, `iterables` là một đối tượng chứa danh sách các phần tử.

### Ví dụ

```python
def square(n) -> int:
    return n**2


nums = [1, 2, 3, 4, 5]
squaredNums = list(map(square, nums))
print(squaredNums)  #[1, 4, 9, 16, 25]

places = ['Nha', 'Trang', 'Khánh', 'Hòa']
lens = list(map(lambda s: len(s), places))
print(lens) #[3, 5, 5, 3]
```

## Hàm filter()

Hàm filter() lọc các phần tử trong danh sách thỏa mãn điều kiện của hàm đặt ra.

### Cú pháp

```python
filter(function, iterables)
```

### Ví dụ

```python
nums = [1, 2, 3, 4, 5]
# Lọc các số lẻ trong dãy
oddNums = list(filter(lambda n: n % 2 != 0, nums))
print(oddNums)  #[1, 3, 5]
```

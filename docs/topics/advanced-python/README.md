# Python nâng cao

Advanced Python

---

## Hàm Python

- Yêu cầu hàng đầu trong lập trình là cần tổ chức mã nguồn có cấu trúc module hóa cao, thuận lợi cho việc sửa lỗi, cải tiến, mở rộng và tái sử dụng. Giải pháp để giải quyết yêu cầu trên là xây dựng chương trình con (hàm).
- Hàm là một đoạn mã nguồn được thiết kế để thực hiện một chức năng chuyên biệt.
- Hàm chỉ thực thi khi được gọi.
- Có thể gọi hàm nhiều lần với các đối số (dữ liệu vào) khác nhau.

- Có 3 loại hàm trong Python:
  - Hàm dựng sẵn (built-in functions)
  - Hàm định nghĩa trong các module dựng sẵn
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
msg = 'Hello World'
PrintMessage(msg)
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

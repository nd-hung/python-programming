# Python cơ bản

Python Basics

---

Môi trường Python tương tác cung cấp bởi [DataCamp](https://www.datacamp.com/).

## Hello, World!


<script type="text/javascript" src="//cdn.datacamp.com/dcl-react.js.gz">  
</script>

<div data-datacamp-exercise data-lang="python" data-height="50">
  <code data-type="sample-code">
    # Chương trình đầu tiên: In ra màn hình câu "Hello, World!"
    print("Hello, World!")
  </code>
</div>

## Kiểu dữ liệu

- Trong Python, tất cả các thành phần của chương trình: kiểu dữ liệu, biến, hàm, chương trình đều là đối tượng.
- Python có các kiểu dữ liệu cơ sở sau:
    - Kiểu chuỗi (text):	str
    - Kiểu số (numeric):	int, float, complex
    - Kiểu danh sách (sequence):	list, tuple, range
    - Kiểu từ điển (mapping): dict
    - Kiểu tập hợp (set):	set, frozenset
    - Kiểu Boolean:	bool
    - Kiểu nhị phânBinary Types:	bytes, bytearray, memoryview
    - Kiểu None:	NoneType

- Có thể xem kiểu dữ liệu của một biến, biểu thức bằng hàm type()
<div data-datacamp-exercise data-lang="python" data-height="100">
  <code data-type="sample-code">
    n = 3721                                
    print("Kiểu dữ liệu: ", type(n))

    PI = 3.1416
    ban_kinh = 1
    dien_tich = PI * ban_kinh**2
    print("Kiểu dữ liệu: ", type(dien_tich))
  </code>
</div>
## Biến, biểu thức, câu lệnh

### Biến (variables)

- Biến là đối tượng dùng để lưu dữ liệu.
- Giá trị của biến có thể thay đổi khi chương trình hoạt động.
- Python không có lệnh khai báo biến, biến được tạo ra khi gán giá trị cho nó.

Cú pháp khởi tạo biến:

```Python
<variable_name> = <value>
<variable_name1>, <variable_name2> = <value1>,<value2>
```

Trong đó:

- Tên biến: đặt theo quy định sau:
  - Tên biến chỉ gồm các ký tự chữ cái, chữ số và dấu gạch dưới '_'.
  - Tên biến phải bắt đầu bằng chữ cái hoặc ký tự gạch dưới.
  - Không được đặt tên biến trùng với [từ khóa của Python](https://docs.python.org/3/reference/lexical_analysis.html#keywords).

Ví dụ:

Tên biến hợp lệ: `delta`, `x1`, `don_gia`, `_123abc`

Tên biến không hợp lệ:

`3VanChinNghin`: bắt đầu bằng chữ số

`Don Gia`: chứa khoảng trắng

`except`: trùng với từ khóa của Python

- Chú ý:
    - Ngôn ngữ Python phân biệt chữ hoa chữ thường (case-sensitive), nên các tên sau là khác nhau: `TinHoc`, `Tinhoc`, `tinHoc`.
    - Nên đặt tên biến ngắn gọn, có nghĩa (diễn tả nội dung nó chứa). Ví dụ, để viết lệnh tính quãng đường đi dựa vào vận tốc và thời gian, thay vì viết `d = v*t`, nên viết `distance = velocity * traveled_time` hoặc `quang_duong = van_toc * thoi_gian`, sẽ giúp câu lệnh dễ hiểu hơn.
    - Với Python 3, có thể đặt tên biến bằng ký tự Unicode (gồm cả tiếng Việt), chẳng hạn: `Ba_Vạn_Chín_Nghìn = 39000` là một khai báo hợp lệ. Tuy nhiên, chỉ nên đặt tên biến bằng các ký tự ASCII.

Một số ví dụ về khởi tạo biến với Python:
  
<div data-datacamp-exercise data-lang="python" data-height="200">
  <code data-type="sample-code">
    # Khai báo biến n và gán số nguyên cho nó
    n = 3721                                
    print("n = ", n)
    
  </code>
</div>


## Các câu lệnh điều khiển

## Lệnh rẽ nhánh if

### Dạng 1: Lệnh if thiếu

- Nếu `<BT logic>` có giá trị đúng (True) thì thực hiện `<Lệnh đơn>` hoặc `<Khối lệnh>`

```python
if <BT logic>: <Lệnh đơn>
hoặc
if <BT logic>: 
    <Khối lệnh>
```

Ví dụ:

```python
n = 5
if n % 2 != 0: print(f'{n} là số lẻ.')
m = 69
if m > 0:
    print(f'm = {m}')
    print(f'{m} là số dương.')
```

### Dạng 2: Lệnh if đủ

- Nếu `<BT logic>` có giá trị đúng (True) thì thực hiện `<Khối lệnh 1>`, ngược lại thực hiện `<Khối lệnh 2>`

```python
if <BT logic>: 
    <Khối lệnh 1>
else:
    <Khối lệnh 2>
```

Hoặc viết gọn hơn khi chỉ có lệnh đơn:

```python
<Lệnh 1> if <BT logic> else <Lệnh 2>
```

Ví dụ:

```python
n = 5
if n % 2 != 0: 
    print(f'{n} là số lẻ.')
else:
    print(f'{n} là số chẵn.')

a, b = 6, 9
print(f'{a} > {b}') if a > b else print(f'{b} > {a}')    
```

### elif

- Trong lệnh if, muốn kiểm tra điều kiện mới khi điều kiện trước không thỏa mãn thì dùng từ khóa `elif`

```python
if <BT logic 1>:        
    <Khối lệnh 1>
elif <BT logic 2>:
    <Khối lệnh 2>
    ...
elif <BT logic n>:
    <Khối lệnh n>
else:
    <Khối lệnh n+1>
```

## Lệnh lặp

### Lệnh lặp while

- Lệnh lặp `while` lặp lại khối lệnh chừng nào `BT điều kiện` còn đúng.

```python
while <BT điều kiện>:
    <Khối lệnh>
```

Ví dụ: Tính tổng các chữ số của số tự nhiên n:

```
n = 123
sum_digits = 0
while n > 0:
    sum_digits += n % 10
    n = n // 10
print(f'Tổng chữ số = {sum_digits}')
```

#### Lệnh break

- Lệnh `break' khi được gọi sẽ dừng vòng lặp.
- Trong ví dụ sau, dù điều kiện lặp là `i < 100`, nhưng nếu i bằng 5 thì dừng vòng lặp, nên chương trình chỉ in ra các số nguyên liên tiếp từ 1 đến 4.

```python
i = 1
while i < 100:
    print(i, end= ' ')
    i += 1
    if i == 5: break
```

#### Lệnh continue

- Lệnh `continue' khi được gọi sẽ chuyển sang vòng lặp kế tiếp.
- Trong ví dụ sau, biến i khởi đầu bằng 0, chừng nào i còn thỏa `< 10` thì tăng i thêm 1 và in ra giá trị của i, nhưng nếu i là số chẵn thì lệnh `continue` được gọi, chương trình chuyển sang xử lý bước lặp tiếp theo mà bỏ qua lệnh `print(i, end=' ')`. Kết quả là chương trình chỉ in ra các số lẻ từ 1 đến 9.

```python
i = 0
while i < 10:
    i += 1
    if i % 2 == 0: continue
    print(i, end= ' ')
```

### Lệnh lặp for

- Lệnh lặp `for` dùng để duyệt từng phần tử trong một dãy (list, tuple, dictionary, set, string).

#### Duyệt danh sách

- Cú pháp

```python
for <biến chạy> in <danh sách>:
    <Khối lệnh>
```

- Ví dụ

```python
Tứ_Linh = ['Long', 'Ly', 'Quy', 'Phượng']
# Cách 1: duyệt từng phần tử của danh sách
for tl in Tứ_Linh:
    print(tl, end=' ')
# Cách 2: duyệt từng phần tử thông qua vị trí trong danh sách    
for i in range(len(Tứ_Linh)):
    print(Tứ_Linh[i], end=' ')
```

#### Duyệt chuỗi ký tự

- Chuỗi là một dãy ký tự vì thế có thể duyệt từng ký tự của chuỗi bằng lệnh for.
- Cú pháp

```python
for ch in <chuỗi>:
    <Lệnh>
```

- Ví dụ

```python
st = 'Nha Trang Khánh Hòa'
for ch in st:
    print(ch) 
```

#### Hàm range()

- hàm `range(<start_value>, <end_value>, <step>)` thường được kết hợp khi muốn thực hiện lệnh lặp với số bước lặp xác định.
- Ví dụ: In 10 dòng 'Hello world'

```python
for i in range(10): # range(0, 10, 1)
    print('Hello world')
```

### Lệnh lặp lồng nhau (nested loop)

- Lệnh lặp lồng nhau: Trong một lệnh lặp chứa lệnh lặp khác.
- Với mỗi bước lặp của vòng lặp ngoài, lệnh lặp bên trong sẽ thực hiện hết một lượt.
- Ví dụ: In bảng cửu chương

```python
for i in range(2, 10):
    for j in range(1, 11):
        print('%3d x %3d = %3d'  % (i, j, i*j))
```

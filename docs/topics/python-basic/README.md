# Python cơ bản

Basic Python

---

## Kiểu dữ liệu

- Trong Python, tất cả các thứ: kiểu dữ liệu, hàm, chương trình đều là đối tượng.

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
    - Ngôn ngữ Python phân biệt chữ hoa chữ thường (case-sensitive), nên các tên sau là khác nhau: TinHoc, Tinhoc, tinHoc.
    - Nên đặt tên biến ngắn gọn, có nghĩa (diễn tả nội dung nó chứa). Ví dụ, để viết lệnh tính quãng đường đi dựa vào vận tốc và thời gian, thay vì viết `d = v*t`, nên viết `distance = velocity * traveled_time` sẽ giúp mã lệnh dễ hiểu hơn.
    - Trong Python 3, có thể đặt tên biến bằng ký tự Unicode (gồm cả tiếng Việt), chẳng hạn: `Ba_Vạn_Chín_Nghìn = 39000` là một khai báo hợp lệ. Tuy nhiên, chỉ nên đặt tên biến bằng các ký tự ASCII.
    
Một số ví dụ về khởi tạo biến:
```Python
n = 3721                                # n chứa số nguyên
x = 123.45                              # a chứa số thực
a,b,c = 32, 4.5, 8                      # tạo 3 biến trên 1 dòng lệnh
st1 = 'Xin chào'                        # st1 chứa chuỗi ký tự đặt giữa cặp dấu nháy đơn
st2 = "Việt Nam"                        # st2 chứa chuỗi ký tự đặt giữa cặp dấu nháy kép
lst = ["Bưởi", "Mướp", "Cam", "Chanh"]  # lst chứa danh sách (list)
myDict = {'Height':1.73, 'Weight':68}   # myDict chứa từ điển (dictionary)
```

## Các câu lệnh điều khiển
### Lệnh rẽ nhánh
### Lệnh lặp

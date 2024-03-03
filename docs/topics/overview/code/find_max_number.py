# Chương trình thực hiện: Đọc 3 số nguyên từ bàn phím. Tìm và in ra số lớn nhất.

# Nhập dữ liệu
a = int(input('Nhập số nguyên a = '))
b = int(input('Nhập số nguyên b = '))
c = int(input('Nhập số nguyên c = '))

# Tìm số lớn nhất trong a,b,c. Sử dụng kỹ thuật 'đặt lính canh'
max_number = a
if max_number < b: max_number = b
if max_number < c: max_number = c

# In kết quả xử lý
print("Số lớn nhất là {}".format(max_number))

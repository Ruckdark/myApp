#include <iostream>
#include <string>
#include <math.h>
using namespace std;

#include <iostream>
using namespace std;

// Định nghĩa cấu trúc dữ liệu stack sử dụng mảng với template
template <typename T>
class Stack {
private:
    int top;
    int capacity;
    T *arr;
public:
    // Default constructor
    Stack() {
        top = -1;
        capacity = 100;
        arr = new T[capacity];
    }   
    Stack(int size) {
        top = -1;
        capacity = size;
        arr = new T[size];
    }
    ~Stack() {
        delete[] arr;
    }
    void Push(T c) {
        if (top == capacity - 1) {
            cout << "Tràn stack" << endl;
            return;
        }
        arr[++top] = c;
    }
    void Pop() {
        if (top == -1) {
            cout << "Stack rỗng" << endl;
            return;
        }
        top--;
    }
    T Top() {
        if (top == -1) {
            cout << "Stack rỗng" << endl;
            return T();
        }
        return arr[top];
    }
    bool isEmpty() {
        return top == -1;
    }
};

// Hàm kiểm tra xem ký tự có phải là toán tử hay không
bool kiemTraToanTu(char c) {
    return (c == '+' || c == '-' || c == '*' || c == '/' || c== '^');
}

// Hàm trả về độ ưu tiên của toán tử
int doUuTien(char c) {
    if (c == '+' || c == '-') return 1;
    if (c == '*' || c == '/') return 2;
    if (c == '^') return 3;
    return 0;
}

// Hàm chuyển đổi biểu thức trung tố sang hậu tố
string trungToSangHauTo(string trungTo) {
    // Khởi tạo một stack rỗng để lưu trữ các toán tử và dấu ngoặc
    Stack<char> nganXepToanTu;
    // Khởi tạo một chuỗi rỗng để lưu kết quả biểu thức hậu tố
    string hauTo = "";
    // Duyệt từng ký tự của biểu thức trung tố
    for (int i = 0; i < trungTo.length(); i++) {
        char c = trungTo[i];
        // Nếu ký tự là toán tử
        if (kiemTraToanTu(c)) {
            // Lấy các toán tử từ đỉnh stack ra và thêm vào chuỗi kết quả cho đến khi gặp một toán tử có độ ưu tiên thấp hơn hoặc bằng hoặc stack rỗng
            while (!nganXepToanTu.isEmpty() && doUuTien(nganXepToanTu.Top()) >= doUuTien(c)) {
                hauTo += nganXepToanTu.Top();
                nganXepToanTu.Pop();
            }
            // Đẩy toán tử hiện tại vào stack
            nganXepToanTu.Push(c);
        } else if (c == '(') { // Nếu ký tự là dấu mở ngoặc
            // Đẩy dấu mở ngoặc vào stack
            nganXepToanTu.Push(c);
        } else if (c == ')') { // Nếu ký tự là dấu đóng ngoặc
            // Lấy các toán tử từ đỉnh stack ra và thêm vào chuỗi kết quả cho đến khi gặp dấu mở ngoặc
            while (!nganXepToanTu.isEmpty() && nganXepToanTu.Top() != '(') {
                hauTo += nganXepToanTu.Top();
                nganXepToanTu.Pop();
            }
            // Loại bỏ dấu mở ngoặc khỏi stack
            if (!nganXepToanTu.isEmpty()) nganXepToanTu.Pop();
        } else { // Nếu ký tự là toán hạng
            // Thêm toán hạng vào chuỗi kết quả
            hauTo += c;
        }
    }
    // Sau khi duyệt xong biểu thức trung tố, lấy các toán tử còn lại trong stack ra và thêm vào chuỗi kết quả
    while (!nganXepToanTu.isEmpty()) {
        hauTo += nganXepToanTu.Top();
        nganXepToanTu.Pop();
    }
    // Trả về chuỗi kết quả là biểu thức hậu tố
    return hauTo;
}

// Hàm tính toán giá trị của một phép toán
int tinhToan(char toanTu, int toanHang1, int toanHang2) {
    switch (toanTu) {
        case '+': return toanHang1 + toanHang2;
        case '-': return toanHang1 - toanHang2;
        case '*': return toanHang1 * toanHang2;
        case '/': return toanHang1 / toanHang2;
        case '^': return pow(toanHang1,toanHang2);
    }
    return 0;
}

// Hàm tính giá trị của biểu thức hậu tố
int tinhGiaTriHauTo(string hauTo) {
    // Khởi tạo một stack rỗng để lưu trữ các giá trị toán hạng
    Stack<int> nganXepToanHang;
    // Duyệt từng ký tự của biểu thức hậu tố
    for (int i = 0; i < hauTo.length(); i++) {
        char c = hauTo[i];
        // Nếu ký tự là toán tử
        if (kiemTraToanTu(c)) {
            // Lấy hai giá trị toán hạng từ đỉnh stack ra
            int toanHang2 = nganXepToanHang.Top();
            nganXepToanHang.Pop();
            int toanHang1 = nganXepToanHang.Top();
            nganXepToanHang.Pop();
            // Tính giá trị của phép toán và đẩy kết quả vào stack
            int ketQua = tinhToan(c, toanHang1, toanHang2);
            nganXepToanHang.Push(ketQua);
        } else { // Nếu ký tự là toán hạng
            // Đổi ký tự thành giá trị số và đẩy vào stack
            int giaTri;
            switch (c) {
                case 'D': giaTri = 6; break;
                case 'E': giaTri = 2; break;
                case 'F': giaTri = 9; break;
                case 'G': giaTri = 12; break;
                case 'H': giaTri = 4; break;
                case 'I': giaTri = 1; break;
                case 'A': giaTri = 27; break;
                case 'B': giaTri = 3; break;
                case 'C': giaTri = 11; break;
            }
            nganXepToanHang.Push(giaTri);
        }
    }
    // Sau khi duyệt xong biểu thức hậu tố, giá trị cuối cùng trong stack chính là kết quả của biểu thức
    return nganXepToanHang.Top();
}

int main() {
    string trungTo = "(A+B-C)*D/E-(F-G)";
    string hauTo = trungToSangHauTo(trungTo);
    cout << " a)\n Trung to: " << trungTo << endl;
    cout << " Hau to: " << hauTo << endl;
    trungTo = "(D^E-F)*(G/H+I)-A/B+C";
    hauTo = trungToSangHauTo(trungTo);
    cout << " b)\n Trung to: " << trungTo << endl;
    cout << " Hau to: " << hauTo << endl;
    cout << " c) Gia tri bieu thuc hau to P tuong ung voi Q o cau b) la: \n " << "Ket qua: " << tinhGiaTriHauTo(hauTo) << endl;
    system("pause");
    return 0;
}

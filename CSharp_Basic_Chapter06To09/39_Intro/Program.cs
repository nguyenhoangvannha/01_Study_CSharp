/*
Phần 6: Lập trình Windows Form cơ bản trong C#
Bài số 39
Giới thiệu về Windows Form (P.1)
16:33
Bài số 40
Giới thiệu về Windows Form (P.2)
14:46
Bài số 41
Giới thiệu về thanh công cụ Toolbox & Properties
19:52
Bài số 42
MessageBox
14:06
Bài số 43
Panel & SplitContainer
14:41
Bài số 44
Các control cơ bản nhất: Label,Textbox, Button
20:37
Bài số 45
Checkbox, RadioButton
21:32
Bài số 46
Picturebox
24:51
Bài số 47
DateTimePicker & MonthCalendar
15:20
Bài số 48
ListBox (P.1)
15:55
Bài số 49
ListBox (P.2)
21:36
Bài số 50
ComboBox
22:06
Bài số 51
CheckedListBox24:44
Bài số 52
Project tổng hợp - Quản lý sản phẩm (P.1)
21:04
Bài số 53
Project tổng hợp - Quản lý sản phẩm (P.2)
17:39
Bài số 54
Project tổng hợp - Quản lý sản phẩm (P.3)
18:44
Phần 7: Các bài tập rèn luyện tổng hợp - Có đáp án
Bài số 55
Bài tập rèn luyện 1 - Vẽ giao diện và xử lý sự kiện lúc Runtime (P.1)
11:15
Bài số 56
Bài tập rèn luyện 1 - Vẽ giao diện và xử lý sự kiện lúc Runtime (P.2)
15:38
Bài số 57
Bài tập rèn luyện 2 - Chương trình tính tiền bán sách (P.1)
13:35
Bài số 58
Bài tập rèn luyện 2 - Chương trình tính tiền bán sách (P.2)
19:47
Bài số 59
Bài tập rèn luyện 3 - Thiết kế giao diện xử lý chuỗi (P.1)
20:02
Bài số 60
Bài tập rèn luyện 3 - Thiết kế giao diện xử lý chuỗi (P.2)
17:23
Bài số 61
Bài tập rèn luyện 3 - Thiết kế giao diện xử lý chuỗi (P.3)
15:50
Bài số 62
Bài tập rèn luyện 3 - Thiết kế giao diện xử lý chuỗi (P.4)
16:27
Bài số 63
Bài tập rèn luyện 4 - Viết chương trình đặt vé cho Rạp chiếu phim (P.1)
18:38
Bài số 64
Bài tập rèn luyện 4 - Viết chương trình đặt vé cho Rạp chiếu phim (P.2)
19:00
Bài số 65
Bài tập rèn luyện 4 - Viết chương trình đặt vé cho Rạp chiếu phim (P.3)
17:24
Bài số 66
Bài tập rèn luyện 5 - Thiết kế giao diện tương tác với mảng
17:22
Phần 8: Các bài tập rèn luyện tổng hợp - tự giải
Bài số 67
Bài tập rèn luyện 6 - Thiết kế màn hình Hóa đơn bán xe
03:02
Bài số 68
Bài tập rèn luyện 7 - Viết Game Caro 2 người chơi với nhau04:22
Bài số 69
Bài tập rèn luyện 8 - Viết phần mềm Kiểm tra gõ phím
03:06
Bài số 70
Bài tập rèn luyện 9 - Viết phần mềm tương tự MsPaint
04:53
Bài số 71
Bài tập rèn luyện 10 - Viết game Xếp hình
04:36
Phần 9: Tổng kết khóa học
Bài số 72
Tổng kết toàn bộ khóa học
01:20 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _39_Intro
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}

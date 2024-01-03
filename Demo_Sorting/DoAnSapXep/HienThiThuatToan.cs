using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace DoAnSapXep
{
    public class HienThiThuatToan
    {
        //Một số biến toàn cục
        public  static ListBox codeListBox;
        public static TextBox yTuongThuatToan;
        public static string yTuong;
        public static ManualResetEvent tamdunglistbox = new ManualResetEvent(true);
        public static string[] ChuyenText(string doc)
        {
            string[] text;
            text = doc.Split('\n');//Cac string den xuong dong
            return text;
        }
        #region Hàm add Ý Tưởng
        private static void addYTuong()
        {
            yTuongThuatToan.Clear();
            yTuongThuatToan.Text = yTuong;
        }
        #endregion
        public static void ChayCodeC(int line)
        {
            Thread.Sleep(ThamSo.ThoiGianDoi * 50);
            // chờ sign nếu có thì đợi đến vô tận 
            tamdunglistbox.WaitOne(Timeout.Infinite);
           
            codeListBox.SelectedIndex = line;
            if (Mainform.isDebug==true)
            {
                tamdunglistbox.Reset();  
            }

        }

        #region  Các thuật toán

        #region Interchange Sort
        public static void InterchangeSort(bool tang = true)
        {
            yTuong =
@"Xuất phát từ đầu dãy, tìm tất các các nghịch thế chứa phần tử này, triệt tiêu chúng bằng cách đổi chỗ 2 phần tử trong cặp nghịch thế. Lặp lại xử lý trên với phần tử kế trong dãy.";
            //Thêm yTuong vào yTuongThuatToan
            addYTuong();

            string[] code = ChuyenText(
@"void InterchangeSort( int a[], int N)
{
    int i, j;
    for(i = 0; i < N - 1; i++)
        for(j = i + 1; j < N; j++)
            if( a[j] < a[i] )
                Swap( a[i], a[j]);
}
");
            //thêm code vào codeListBox 
            codeListBox.Items.Clear();
            foreach (string item in code)
            {
                codeListBox.Items.Add(item);
            }
            //nếu sắp giảm thì sửa lại
            if (!tang)
            {
                codeListBox.Items[5] = "            if( a[j] > a[i] )";
            }
        }
        #endregion

        #region Insertion Sort
        public static void InsertionSort(bool tang = true)
        {
            yTuong =
@"Giả sử có một dãy a0, a1,... ,an-1 trong đó i phần tử đầu tiên a0, a1,... ,ai-1 đã có thứ tự.
Tìm cách chèn phần tử ai vào vị trí thích hợp của đoạn đã được sắp để có dãy mới a0, a1,... ,ai trở nên có thứ tự. Vị trí này chính là vị trí giữa hai phần tử ak-1 và ak thỏa ak-1 < ai < ak(1≤k≤i).";
            // Thêm yTuong vào yTuongThuatToan
            addYTuong();

            string[] code = ChuyenText(
@"void InsertionSort(int a[], int N)
{
    int pos, i;
    int x;
    for(i = 1; i < N; i++)
    {
        x = a[i]; pos = i - 1;
        while((pos >= 0) && (x < a[pos]))
        {
            a[pos + 1] = a[pos];
            pos--;
        }
        a[pos + 1] = x;
    }
}");
            // Thêm code vào codeListBox

            codeListBox.Items.Clear();
            foreach (string item in code)
            {
                codeListBox.Items.Add(item);
            }
            if (!tang)
            {
                codeListBox.Items[7] = "        while((pos >= 0) && (x > a[pos]))";
            }
        }
        #endregion

        #region Selection Sort
        public static void SelectionSort(bool tang = true)
        {
            //vietnamese
            yTuong =
@"Chọn phần tử nhỏ nhất trong N phần tử trong dãy hiện hành ban đầu.
Đưa phần tử này về vị trí đầu dãy hiện hành.
Xem dãy hiện hành chỉ còn N-1 phần tử của dãy hiện hành ban đầu.
    Bắt đầu từ vị trí thứ 2;
    Lặp lại quá trình trên cho dãy hiện hành... đến khi dãy hiện hành chỉ còn 1 phần tử.";

            //Thêm yTuong vào yTuongThuatToan
            addYTuong();


            string[] code = ChuyenText(
@"void SelecttionSort(int arr[], int N)
{
    int min, i, j;
    for (i=0; i < N-1; i++)
        {
                min = i;
                for (j=i+1; j <N; j++)
                if (a[j] < a[min])
                    min=j;
                    Swap(a[min], a[i]);   
        } 
}");
            //thêm code vào codeListBox

            codeListBox.Items.Clear();
            foreach (string item in code)
            {
                codeListBox.Items.Add(item);
            }
            //Nếu sắp xếp giảm dần thì sửa lại
            if (!tang)
            {
                codeListBox.Items[7] = "             if (a[j] > a[min])";
            }
        }
        #endregion

        #region Quick Sort
        public static void QuickSort(bool tang = true)
        {
            yTuong =
@"Giải thuật QuickSort sắp xếp dãy a1, a2 ..., aN dựa trên việc phân hoạch dãy ban đầu thành 3 phần :
Phần 1:Gồm các phần tử  có giá trị bé hơn x
Phần 2: Gồm các phần tử  có giá trị bằng  x 
Phần 3: Gồm các phần tử  có giá trị lớn hơn x
Với x là giá trị của một phần tử  tùy ý trong dãy ban đầu.";
            //Thêm yTuong vào yTuongThuatToan
            addYTuong();

            string[] code = ChuyenText(
@"void QuickSort(int a[], int left, int right)
{
    int i, j, x;
    x = a[(left + night)/2];
    i = left, j = right;
    do
    {
        while(a[i] < x)
            i++;
        while(x < a[j])
            j--;
        if(i <= j)
        {
            Swap(a[i], a[j]);
            i++, j--;
        }            
    }while(i <= j);
    if(left < j)
        QuickSort(a, left, j);
    if(i < right)
        QuickSort(a, i, right);
}");
            //thêm code vào codeListBox 
            codeListBox.Items.Clear();
            foreach (string item in code)
            {
                codeListBox.Items.Add(item);
            }
            //nếu sắp giảm thì sửa lại
            if (!tang)
            {
                codeListBox.Items[7] = "        while(a[i] > x)";
                codeListBox.Items[9] = "        while(x > a[j])";
            }
        }
        #endregion

        #region Bubble Sort
        public static void BubbleSort(bool tang = true)
        {
            yTuong =
@"Xuất phát từ cuối dãy, đổi chỗ các cặp phần tử kế cận để đưa phần tử nhỏ hơn trong cặp phần tử đó về vị trí đúng đầu dãy hiện hành, sau đó sẽ không xét đến nó ở bước tiếp theo, do vậy ở lần xử lý thứ i sẽ có vị trí đầu dãy là i. 
Lặp lại xử lý trên cho đến khi không còn cặp phần tử nào để xét.";
            //Thêm yTuong vào yTuongThuatToan
            addYTuong();

            string[] code = ChuyenText(
@"void BubbleSort(int a[], int N)
{
    int i,j;
    for(i = 0; i < N - 1; i++)
        for(j = N - 1; j > i; j--)
        if(a[j] < a[j - 1])
            Swap(a[j], a[j - 1]);
}
");
            //thêm code vào codeListBox 
            codeListBox.Items.Clear();
            foreach (string item in code)
            {
                codeListBox.Items.Add(item);
            }
            //nếu sắp giảm thì sửa lại
            if (!tang)
            {
                codeListBox.Items[5] = "       if(a[j] > a[j - 1])";
            }
        }
        #endregion

        #region Merge Sort
        public static void MergeSort(bool tang = true)
        {
            yTuong =
@"Sắp xếp dãy a(1),a(2),...,a(n) dựa trên nhận xét sau :
-Mỗi dãy a(1),a(2),...,a(n) bất kỳ là một tập hợp các dãy con liên tiếp mà mỗi dãy con đều đã có thứ tự. 
-Dãy đã có thứ tự coi như có 1 dãy con.           
Hướng tiếp cận : tìm cách làm giảm số dãy con không giảm của dãy ban đầu.";
            //Thêm yTuong vào yTuongThuatToan
            addYTuong();

            string[] code = ChuyenText(
@"int b[MAX], c[MAX], nb, nc;
int Min(int a, int b)
{
    if(a > b) return b;
    else return a;
}
void Distribute(int a[], int N, int &nb, int &nc, int k)
{
    int i, pa, pb, pc;
    pa = pb = pc = 0 ;
    while(pa < N)
    {
        for(i = 0; (pa < N) && (i < k); i++, pa++, pb++)
            b[pb] = a[pa];
        for(i = 0; (pa < N) && (i < k); i++, pa++, pc++)
            c[pc] = a[pa];
    }
    nb = pb; nc = pc;
}
void Merge(int a[], int nb, int nc, int k)
{
    int p, pb, pc, ib, ic, kb, kc;
    p = pb = pc = 0; ib = ic = 0;
    while((nb > 0) && (nc > 0))
    {
        kb = Min(k, nb); kc = Min(k, nc);
        if(c[pc + ic] < b[pb + ib] == false)
        {
            a[p++] = b[pb + ib]; ib++;
            if(ib == kb)
            {
                for(;ic < kc; ic++)
                    a[p++] = c[pc + ic];
                pb += kb; pc += kc; ib = ic = 0;
                nb -= kb; nc -= kc;
            }
        }
        else
        {
            a[p++] = c[pc + ic]; ic++;
            if(ic == kc)
            {
                for(;ib < kb; ib++)
                    a[p++] = b[pb + ib];
                pb += kb; pc += kc; ib = ib = 0;
                nb -= kb; nc -= kc;
            }
        }
    }
}
void MergeSort(int a[], int N)
{
        int k;
        for(k = 1; k < N; k*= 2)
        {
            Distribute(a, N, nb, nc, k);
            Merge(a, nb, nc, k);
        }
}
");
            //thêm code vào codeListBox 
            codeListBox.Items.Clear();
            foreach (string item in code)
            {
                codeListBox.Items.Add(item);
            }
            //nếu sắp giảm thì sửa lại
            if (!tang)
            {
                codeListBox.Items[26] = "        if(c[pc + ic] > b[pb + ib] == false)";
            }
        }
        #endregion

        #endregion


    }
}

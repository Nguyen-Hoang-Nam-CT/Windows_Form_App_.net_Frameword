using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace B_4._5
{
    class Array_
    {
        public static void Random_Arr(ref int[] arr)
        {
            arr = new int[10];
            Random r = new Random();
            for(int i = 0; i < arr.Length; i++)
                arr[i] = r.Next(1, 100);
        }
        public static void GanGiaTriMang(ref TextBox a, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                a.Text += " " + arr[i];
        }
        public static int TimMin(int[] arr)
        {
            if (arr.Length == 0)
                return int.MinValue;
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
                if (min > arr[i])
                    min = arr[i];
            return min;
        }
        public static int TongMang(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];
            return sum;
        }
        public static void Tang2(int[] arr, ref TextBox a)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] += 2;
            a.Text = "Mảng sau khi tăng: ";
            for (int i = 0; i < arr.Length; i++)
                a.Text += " " + arr[i];
        }
        public static int demPhanTuLe(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] % 2 != 0)
                    count++;
            return count;
        }
        public static void swap_(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static void Quick_Sort_Tang(int[] arr, int left, int right)
        {
            if (left >= right)
                return;
            int i = left, j = right, pivot = arr[(left + right) / 2];
            do
            {
                while (arr[i] < pivot)
                    i++;
                while (arr[j] > pivot)
                    j--;
                if(i <= j)
                {
                    swap_(ref arr[i], ref arr[j]);
                    i++;
                    j--;
                }    
            } while (i < j);
            Quick_Sort_Tang(arr, left, j);
            Quick_Sort_Tang(arr, i, right);
        }
        public static void Quick_Sort_Giam(int[] arr, int left, int right)
        {
            if (left >= right)
                return;
            int i = left, j = right, pivot = arr[(left + right) / 2];
            do
            {
                while (arr[i] > pivot)
                    i++;
                while (arr[j] < pivot)
                    j--;
                if (i <= j)
                {
                    swap_(ref arr[i], ref arr[j]);
                    i++;
                    j--;
                }
            } while (i < j);
            Quick_Sort_Giam(arr, left, j);
            Quick_Sort_Giam(arr, i, right);
        }
        public static int TongGiaTriLeTrongMang(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] % 2 != 0)
                    sum =+ arr[i];
            return sum;
        }
    }
}

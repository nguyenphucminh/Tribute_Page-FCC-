using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Time
{
    class ThoiGian
    {
        private int _Year;
        private int _Month;
        private int _Day;
        private int _Hour;
        private int _Minute;
        private int _Second;
        //xay dung cac thuộc tính property
        public int Nam
        {
            get { return _Year; }
            set { _Year = value; }
        }
        public int Thang
        {
            get { return _Month; }
            set
            {
                if ((value >= 1) && (value <= 12))
                    _Month = value;
                else
                    _Month = 1;
            }
        }
        public int Ngay
        {
            get { return _Day; }
            set
            {
                if ((value >= 1) && (value <= 30))
                    _Day = value;
                else
                    _Day = 1;
            }
        }
        public int Gio
        {
            get { return _Hour; }
            set
            {
                if ((value >= 0) && (value <= 23))
                    _Hour = value;
                else
                    _Hour = 0;
            }
        }
        public int Phut
        {
            get { return _Second; }
            set
            {
                if ((value >= 0) && (value <= 59))
                    _Minute = value;
                else
                    _Minute = 0;
            }
        }
        public int Giay
        {
            get { return _Second; }
            set
            {
                if ((value >= 0) && (value <= 59))
                    _Second = value;
                else
                    _Second = 0;
            }
        }
        //ham tạo không tham so public
        public ThoiGian()
        {
            this.Nam = 2014;
            this.Thang = 09;
            this.Ngay = 20;
            Gio = 10;
            Phut = 30;
            Giay = 40;
        }
        //hàm tạo 6 tham số
        public ThoiGian(int Date, int Month, int Year, int Hour, int Minute, int Second)
        {
            Nam = Year;
            Thang = Month;
            Ngay = Date;
            Gio = Hour;
            Phut = Minute;
            Giay = Second;
        }
        //hàm tạo 3 tham số
        public ThoiGian(int Ngay, int Thang, int Nam)
        {
            this.Ngay = Ngay;
            this.Thang = Thang;
            this.Nam = Nam;
        }
        //hàm tạo sao chép
        public ThoiGian(ThoiGian tg)
        {
            Nam = tg.Nam;
            Thang = tg.Thang;
            Ngay = tg.Ngay;
            Gio = tg.Gio;
            Phut = tg.Phut;
            Giay = tg.Phut;
        }
        //hàm tạo với tham số  j đố ợng của lớp System.DateTime public
        public ThoiGian(System.DateTime tg)
        {
            Nam = tg.Year;
            Thang = tg.Month;
            Ngay = tg.Day;
            Gio = tg.Hour;
            Phut = tg.Minute;
            Giay = tg.Second;
        }
        //hàm hiện thị thời gian
        public void Hien()
        {
            System.Console.WriteLine("\t Ngay:{0}/{1}/{2}", Ngay, Thang, Nam); 
            System.Console.WriteLine("\t Gio:{0}:{1}:{2}", Gio, Phut, Giay);
        }
    }
}

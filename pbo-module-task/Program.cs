using System;
using System.Net.NetworkInformation;

namespace KebunBinatang
{
    public class Hewan
    {
        public string Nama;
        public int Umur;

        public Hewan(string Nama, int Umur)
        {
            this.Nama = Nama;
            this.Umur = Umur;
        }
        public virtual string Suara()
        {
            return "Hewan ini bersuara";
        }
        public virtual string InfoHewan()
        {
            return $"Nama: {Nama}, Umur: {Umur} tahun";
        }

    }

    public class Mamalia : Hewan
    {
        public int JumlahKaki;

        public Mamalia(string nama, int umur, int jumlahkaki)
            : base(nama, umur)
        {
            JumlahKaki = jumlahkaki;
        }
        public override string InfoHewan()
        {
            return base.InfoHewan() + $", Jumlah Kaki: {JumlahKaki}";
        }
    }

    public class Reptil : Hewan
    {
        public double PanjangTubuh;

        public Reptil(string nama, int umur, double panjangTubuh)
            : base(nama, umur)
        {
            PanjangTubuh = panjangTubuh;
        }

        public override string InfoHewan()
        {
            return base.InfoHewan() + $", Panjang Tubuh: {PanjangTubuh} meter";
        }
    }
    public class Singa : Mamalia
    {
        public Singa(string nama, int umur, int jumlahKaki)
            : base(nama, umur, jumlahKaki)
        {
        }
        public override string Suara()
        {
            return "Singa Mengaum!";
        }
        public void Mengaum()
        {
            Console.WriteLine("Singa mengaum dengan keras!");
        }
    }
    public class Gajah : Mamalia
    {
        public Gajah(string nama, int umur, int jumlahKaki)
            : base(nama, umur, jumlahKaki)
        {

        }
        public override string Suara()
        {
            return "Gajah sedang menderum !";

        }
    }

    public class Ular : Reptil
    {
        public Ular(string nama, int umur, double panjangTubuh)
            : base(nama, umur, panjangTubuh)
        {
        }
        public override string Suara()
        {
            return "Ular mendesis!";
        }
        public void Merayap()
        {
            Console.WriteLine("Ular sedang merayap diam diam");
        }
    }
    public class Buaya : Reptil
    {
        public Buaya(string nama, int umur, double panjangTubuh)
            : base(nama, umur, panjangTubuh)
        {
        }

        public override string Suara()
        {
            return "Buaya menggeram!";
        }
    }
    public class KebunBinatang
    {
        public List<Hewan> KoleksiHewan;
        public KebunBinatang()
        {
            KoleksiHewan = new List<Hewan>();
        }

        public void TambahHewan(Hewan hewan)
        {
            KoleksiHewan.Add(hewan);
            Console.WriteLine($"{hewan.Nama} telah ditambahkan ke kebun binatang.");

        }
        public void DaftarHewan()
        {
            Console.WriteLine("Daftar hewan di kebun binatang:");
            foreach (var hewan in KoleksiHewan)
            {
                Console.WriteLine(hewan.InfoHewan());
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            KebunBinatang kebunBinatang = new KebunBinatang();

            Singa singa = new Singa("Selene", 3, 4);
            Gajah gajah = new Gajah("Samba", 8, 4);
            Ular ular = new Ular("Cuki", 2, 29);
            Buaya buaya = new Buaya("Ciko", 5, 25);

            kebunBinatang.TambahHewan(singa);
            kebunBinatang.TambahHewan(gajah);
            kebunBinatang.TambahHewan(ular);
            kebunBinatang.TambahHewan(buaya);
            kebunBinatang.DaftarHewan();

            Console.WriteLine(singa.Suara());
            Console.WriteLine(gajah.Suara());
            Console.WriteLine(ular.Suara());
            Console.WriteLine(buaya.Suara());

            singa.Mengaum();
            ular.Merayap();



        }
    }
}
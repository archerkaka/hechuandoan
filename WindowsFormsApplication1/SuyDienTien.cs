using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class SuyDienTien
    {

        bool GSuyDienDungSai(List<string> gt, List<string> kl, List<string> boluat)// suy dien tien kiem tra nhom su kien A co suy ra duoc su kien b hay khong
        {
            Rules rules = new Rules();
            List<string> Known=gt;
            bool found=true;
            while (found && kl.Except(Known).Any()) //dk known chua bao gom ket luan;
            {
                found = false;
                foreach (string line in boluat)
                {
                    List<string> sukienboluat = rules.NhomSuKien(line);
                    List<string> ketquaboluat = rules.KetQua(line);

                    if (!sukienboluat.Except(Known).Any() && ketquaboluat.Except(Known).Any()) //kt xem known co bao gom skbl, known co khong bao gom kq;
                    {
                        Known.AddRange(ketquaboluat);
                        Known=Known.Distinct().ToList();
                        found = true;
                        break;
                    } 
                }
            }
            if (!kl.Except(Known).Any())
                return true;
            else
                return false;
        }

        public List<string> SuyDien(List<string> sukiens, List<string> boluat)// suy dien tien kq tra ve la tap kl dc sinh ra tu gia thuyet
        {
            List<string> kq = new List<string>();
            foreach(string line in boluat)
            {
                Rules rules = new Rules();
                List<string> KL = rules.KetQua(line);
                if (GSuyDienDungSai(sukiens, KL, boluat))
                    kq.AddRange(KL);
            }
            return kq;
        }
        

        public List<string> SuyDienLui(List<string> gt, List<string> kl, List<string> boluat)//tra ve cac tap luat r da duoc su dung
        {
            Rules rules = new Rules();
            List<string> Known = kl;
            List<string> r = new List<string>();

            bool found = true;
            while (found && gt.Except(Known).Any()) //dk known chua bao gom gt
            {
                found = false;
                foreach (string line in boluat)
                {
                    List<string> sukienboluat = rules.NhomSuKien(line);
                    List<string> ketquaboluat = rules.KetQua(line);
                    if (!ketquaboluat.Except(Known).Any() && sukienboluat.Except(Known).Any()) //kt xem known co bao gom kqbl, known co khong bao gom skbl;
                    {
                        Known.AddRange(sukienboluat);
                        Known = Known.Distinct().ToList();
                        r.Add(line);
                        found = true;
                        break;
                    }
                }
            }

            if (!gt.Except(Known).Any())
                return r;
            else
            {
                return null;
            }
        }
        public List<string> CacSuKienCan(List<string> gt, List<string> kl, List<string> boluat)
        {//kl=kq e1,e1,... gt=f9
            Rules rule = new Rules();
            List<string> kq = new List<string>();
            List<string> r = new List<string>();
            foreach (string item in gt)
            {
                List<string> a = new List<string>() { item };
                foreach (string item2 in kl)
                {
                    List<string> b = new List<string>() { item2 };
                    r = SuyDienLui(a, b, boluat);
                    if (r != null)
                    {
                        foreach (string line in r)
                        {
                            kq.AddRange(rule.NhomSuKien(line));
                        }
                    }
                }
                kq=kq.Distinct().ToList();
            }
            return kq;
        }
        public int SuyDienPhanTram(List<string> gt, List<string> kl, List<string> boluat)
        {
            List<string> skc = CacSuKienCan(gt, kl, boluat);
            List<string> have = new List<string>();
            //cac su kien can thiet de co the suy ra kl
            have = gt.Intersect(skc).ToList<string>();    //cac su kien trong gt co the dung
            int k = skc.Count;

            if (k == 0)
                return 0;
            else
                return ((have.Count() * 100) / skc.Count());
        }
        public List<string> CacKQ(List<string> gt, List<string> boluat)
        {
            Rules rule = new Rules();
            List<string> kq = new List<string>();

            foreach (string line in boluat)
            {
                List<string> temp = rule.KetQua(line);
                if (SuyDienPhanTram(gt, temp, boluat) != 0)
                {
                    List<string> tam = rule.KetQua(line);
                    kq.AddRange(tam);
                }
            }
            return kq;
        }
        

    }
}

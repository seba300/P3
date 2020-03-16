using System;
using System.Collections.Generic;
using System.Text;

namespace _3_10
{
    public interface IDostawca
    {
        int Wyslij();
        void Status(int id);
        void Odbierz(int id);

    }
}

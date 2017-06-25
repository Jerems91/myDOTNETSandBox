using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesReutilisables {
    public interface IRemisable {
        double Remise { set; }
        double CalculerRemise();
    }
}

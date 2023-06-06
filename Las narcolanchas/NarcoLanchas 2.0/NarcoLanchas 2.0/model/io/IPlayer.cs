using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarcoLanchas_2._0.model.io
{
    public interface IPlayer
    {
        public string GetName();
        public void PutCrafts(Board b);
        public Coordinate NextShoot(Board b);
    }
}

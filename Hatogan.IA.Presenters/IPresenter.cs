using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.IA.Presenters
{
    public interface IPresenter<FormatDatatype>
    {
        public FormatDatatype Content { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeRental.Presenters
{
    public class BasePresenter<T>
    {
        public BasePresenter(T view)
        {
            View = view;
        }

        protected T View { get; private set; }
    }
}

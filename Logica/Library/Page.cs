using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica.Library
{
    public class Page<T>
    {
        private List<T> _dataList;
        private Label _lable;
        private static int maxReg, _regPerPage, pageCount, numPage;//static para que los elementos mantengan su informacion
        public Page(List<T> dataList, Label lable, int regPerPage)
        {
            _dataList = dataList;
            _lable = lable;
            _regPerPage = regPerPage;
            ChargeData();
        }

        private void ChargeData()
        {
            numPage = 1;
            maxReg = _dataList.Count;
            pageCount = maxReg / _regPerPage;
            if ((maxReg % _regPerPage) > 0)
            {
                pageCount ++;
            }
            _lable.Text = $"Page 1/{pageCount}";
        }

        public int first()
        {
            numPage = 1;
            _lable.Text = $"Page {numPage}/{pageCount}";
            return numPage;
        }

        public int prior()
        {
            if (numPage > 1)
            {
                numPage --;
                _lable.Text = $"Page {numPage}/{pageCount}";
            }
            return numPage;
        }

        public int next()
        {
            if (numPage == pageCount)
            {
                numPage--;
            }
            if (numPage < pageCount)
            {
                numPage++;
                _lable.Text = $"Page {numPage}/{pageCount}";
            }
            return numPage;
        }

        public int last()
        {
            numPage = pageCount;
            _lable.Text = $"Page {numPage}/{pageCount}";
            return numPage;
        }
    }
}

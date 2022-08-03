using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnOff
{
   
    public class  OnOrOff
    {
        bool _isOn;
        bool _isOff;
        public bool IsOn
        {
            get{return _isOn;}
            set{_isOn = value;}
        }

        public bool IsOff
        {
            get { return _isOff; }
            set { _isOff = value; }
        }
       
        public bool IsItOn()
        {
            bool X = false;
            if (IsOn)
            {
                X = true;
            }
           
            return X;
        }
        public bool IsItOff()
        {
            bool X = false;
            if (IsOff)
            {
                X = true;
            }
            
            return X;
        }
    }
}

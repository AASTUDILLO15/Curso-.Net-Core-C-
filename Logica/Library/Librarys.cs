﻿using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Library
{
    public class Librarys : Conection
    {
        public UploadImage uploadImage = new UploadImage();
        public TextBoxEvent textBoxEvent = new TextBoxEvent();
        public NumBoxEvent numBoxEvent = new NumBoxEvent();
    }
}
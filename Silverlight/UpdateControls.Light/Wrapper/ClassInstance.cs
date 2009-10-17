﻿/**********************************************************************
 * 
 * Update Controls .NET
 * Copyright 2009 Mallard Software Designs
 * Licensed under LGPL
 * 
 * http://updatecontrols.net
 * http://updatecontrolslight.codeplex.com/
 * 
 **********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;

namespace UpdateControls.XAML.Wrapper
{
    class ClassInstance
    {
        private Type _wrappedType;
        private List<ClassProperty> _classProperties;

        public ClassInstance(Type wrappedType)
        {
            _wrappedType = wrappedType;

            // Create a wrapper for each non-collection property.
            _classProperties = _wrappedType
                .GetProperties()
                .Select(p => new ClassProperty(p, _wrappedType))
                .ToList();
        }

        public IEnumerable<ClassProperty> ClassProperties
        {
            get { return _classProperties; }
        }

        public override string ToString()
        {
            return _wrappedType.Name;
        }
    }
}

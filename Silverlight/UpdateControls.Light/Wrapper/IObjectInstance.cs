/**********************************************************************
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
using System.Windows;
using System.Windows.Threading;

namespace UpdateControls.XAML.Wrapper
{
    public interface IObjectInstance
    {
        object WrappedObject { get; }
        IDictionary<object, IObjectInstance> WrapperByObject { get; }
        Dispatcher Dispatcher { get; }
        ObjectProperty LookupProperty(UpdateControls.XAML.Wrapper.ClassProperty classProperty);
        void SetValue(DependencyProperty dependencyProperty, object value);
    }
}

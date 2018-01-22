﻿// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ICSharpCode.Data.Core.UI.UserControls;

namespace ICSharpCode.Data.EDMDesigner.Core.Windows.EDMWizard
{
    /// <summary>
    /// Interaction logic for EDMWizardErrorUserControl.xaml
    /// </summary>
    public partial class EDMWizardErrorUserControl : WizardErrorUserControl
    {
        public override string Title
        {
            get
            {
                return "Error while generating Entity Model";
            }
        }

        public EDMWizardErrorUserControl()
        {
            InitializeComponent();
        }

        public override void OnActivate()
        {
            
        }
    }
}

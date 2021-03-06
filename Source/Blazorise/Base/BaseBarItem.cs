﻿#region Using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Components;
#endregion

namespace Blazorise.Base
{
    public abstract class BaseBarItem : BaseComponent
    {
        #region Members

        private bool isActive;

        private bool isDisabled;

        private BaseBarDropdown barDropdown;

        private BaseBarDropdownToggler barDropdownToggler;

        #endregion

        #region Methods

        protected override void RegisterClasses()
        {
            ClassMapper
                .Add( () => ClassProvider.BarItem() )
                .If( () => ClassProvider.BarItemActive(), () => IsActive )
                .If( () => ClassProvider.BarItemDisabled(), () => IsDisabled )
                .If( () => ClassProvider.BarItemDropdown(), () => IsDropdown )
                .If( () => ClassProvider.BarItemDropdownShow(), () => IsDropdown && barDropdown?.IsOpen == true );

            base.RegisterClasses();
        }

        internal void Hook( BaseBarDropdown barDropdown )
        {
            this.barDropdown = barDropdown;
        }

        internal void Hook( BaseBarDropdownToggler barDropdownToggler )
        {
            this.barDropdownToggler = barDropdownToggler;
        }

        internal void Toggle()
        {
            barDropdown?.Toggle();

            ClassMapper.Dirty();

            StateHasChanged();
        }

        #endregion

        #region Properties

        protected bool IsDropdown => barDropdown != null;

        [Parameter]
        protected bool IsActive
        {
            get => isActive;
            set
            {
                isActive = value;

                ClassMapper.Dirty();
            }
        }

        [Parameter]
        protected bool IsDisabled
        {
            get => isDisabled;
            set
            {
                isDisabled = value;

                ClassMapper.Dirty();
            }
        }

        [Parameter] protected RenderFragment ChildContent { get; set; }

        #endregion
    }
}

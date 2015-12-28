﻿using Binarysharp.MemoryManagement;
using Binarysharp.MemoryManagement.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema
{
    interface ILabelerView : IView
    {
        // Methods invoked by the presenter (upstream)
        void EventLabelerFinished(List<RemoteRegion> MemoryRegions);
    }

    interface ILabelerModel : IModel
    {
        // Events triggered by the model (upstream)
        event EventHandler EventLabelerFinished;

        // Functions invoked by presenter (downstream)
        void BeginLabeler();
        Snapshot<Object> EndLabeler();
    }

    class LabelerPresenter : Presenter<ILabelerView, ILabelerModel>
    {
        public LabelerPresenter(ILabelerView View, ILabelerModel Model) : base(View, Model)
        {
            // Bind events triggered by the model
            Model.EventLabelerFinished += EndLabelerFinished;
        }

        #region Method definitions called by the view (downstream)

        public void BeginLabeler()
        {
            Model.BeginLabeler();
        }

        public Snapshot<Object> EndLabeler()
        {
            return Model.EndLabeler();
        }

        #endregion

        #region Event definitions for events triggered by the model (upstream)

        private void EndLabelerFinished(Object Sender, EventArgs E)
        {
            View.EventLabelerFinished(null);
        }

        #endregion
    }
}

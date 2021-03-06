﻿using System;
using Windows.Foundation;

namespace Telerik.UI.Xaml.Controls.Input
{
    /// <summary>
    /// Contains information about the <see cref="RadSegmentedControl.SegmentAnimationContextChanged"/> event.
    /// </summary>
    public class SegmentAnimationContextEventArgs : EventArgs
    {
        private Rect layoutSlot;
        private SegmentVisualState visualState;

        /// <summary>
        ///
        /// </summary>
        /// <param name="segment">The segment that has initiated the event.</param>
        public SegmentAnimationContextEventArgs(Segment segment)
        {
            this.layoutSlot = segment.LayoutSlot;
            this.visualState = segment.VisualState;
        }

        /// <summary>
        /// The segment <see cref="Segment.LayoutSlot"/>.
        /// </summary>
        public Rect LayoutSlot
        {
            get
            {
                return this.layoutSlot;
            }
        }

        /// <summary>
        /// The segment <see cref="Segment.VisualState"/>.
        /// </summary>
        public SegmentVisualState VisualState
        {
            get
            {
                return this.visualState;
            }
        }
    }
}
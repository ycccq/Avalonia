﻿namespace Perspex
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using Perspex.Media;

    public abstract class Visual : PerspexObject
    {
        public static readonly ReadOnlyPerspexProperty<Rect> BoundsProperty =
            new ReadOnlyPerspexProperty<Rect>(BoundsPropertyW);

        private static readonly PerspexProperty<Rect> BoundsPropertyW =
            PerspexProperty.Register<Visual, Rect>("Bounds", new Rect());

        public Rect Bounds
        {
            get { return this.GetValue(BoundsPropertyW); }
            protected set { this.SetValue(BoundsPropertyW, value); }
        }

        public virtual IEnumerable<Visual> VisualChildren
        {
            get { return Enumerable.Empty<Visual>(); }
        }

        public virtual void Render(IDrawingContext context)
        {
            Contract.Requires<ArgumentNullException>(context != null);
        }
    }
}

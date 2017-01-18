using System.Windows;

namespace WPFCore.XAML.DragDrop
{
    /// <summary>
    /// Diese Schnittstelle wird zur Implementation eines Drag-and-Drop-Advisors f�r die Drag-Quelle verwendet.
    /// </summary>
    public interface IDragSourceAdvisor
    {
        /// <summary>
        /// Liefert das UI-Element, welches als Drag-Quelle einer Drag-Operation dient bzw. liefert dieses.
        /// </summary>
        /// <value>The target UI.</value>
        UIElement SourceUI { get; set; }

        /// <summary>
        /// Liefert die unterst�tzten Effekte.
        /// </summary>
        /// <value>Die unterst�tzten Effekte.</value>
        DragDropEffects SupportedEffects { get; }

        /// <summary>
        /// Liefert die Daten eines Drag-Objektes.
        /// </summary>
        /// <param name="draggedElt">Das UI-Element der Drag-Quelle.</param>
        /// <returns>Die Daten der Drag-Operation.</returns>
        DataObject GetDataObject(UIElement draggedElt);

        /// <summary>
        /// Beendet die Drag-Operation.
        /// </summary>
        /// <param name="draggedElt">Das UI-Element der Drag-Quelle.</param>
        /// <param name="finalEffects">Die abschlie�enden Effekte.</param>
        void FinishDrag(UIElement draggedElt, DragDropEffects finalEffects);

        /// <summary>
        /// Ermittelt, ob ein UI-Element als Drag-Quelle dient
        /// </summary>
        /// <param name="dragElt">Das UI-Element der Drag-Quelle.</param>
        /// <returns>
        /// <c>true</c> wenn UI-Element als Drag-Quelle dienen kann; andernfalls <c>false</c>.
        /// </returns>
        bool IsDraggable(UIElement dragElt);

        /// <summary>
        /// Liefert den �bergeordneten Container.
        /// </summary>
        /// <returns>Das UIElement, welches den �bergeordneten Containr darstellt.</returns>
        UIElement GetTopContainer();
    }
}
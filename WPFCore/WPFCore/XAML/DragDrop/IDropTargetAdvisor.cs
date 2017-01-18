using System.Windows;

namespace WPFCore.XAML.DragDrop
{
    /// <summary>
    /// Diese Schnittstelle wird zur Implementation eines Drag-and-Drop-Advisors f�r das Drop-Ziel verwendet.
    /// </summary>
    public interface IDropTargetAdvisor
    {
        /// <summary>
        /// Liefert das UI-Element, welches als Drop-Ziel einer Drag-Operation dient bzw. liefert dieses.
        /// </summary>
        /// <value>The target UI.</value>
        UIElement TargetUI { get; set; }

        /// <summary>
        /// Liefert einen Wert, der angibt, ob Maus-Effekte w�hrend der Drag-Operation aktiviert sind.
        /// </summary>
        /// <value><c>true</c> wenn Maus-Effekt aktiviert sind; andernfalls <c>false</c>.</value>
        bool ApplyMouseOffset { get; }

        /// <summary>
        /// Pr�ft, ob die Daten einer Drag-Operation g�ltig f�r das Drop-Ziel sind.
        /// </summary>
        /// <param name="obj">Die Daten.</param>
        /// <returns>
        /// <c>true</c> wenn die Daten akkzeptiert werden; andernfalls <c>false</c>.
        /// </returns>
        bool IsValidDataObject(IDataObject obj);

        /// <summary>
        /// Callback-Methode, wenn die Drag-Operation mit dem Drop auf dem Ziel-Element beendet wird.
        /// </summary>
        /// <param name="obj">Die Daten der Operation.</param>
        /// <param name="dropPoint">Koordinaten des Drop-Punktes.</param>
        void OnDropCompleted(IDataObject obj, Point dropPoint);

        /// <summary>
        /// Liefert visuelles Feedback, wenn die Drag-Operation �ber dem Drop-Ziel ist.
        /// </summary>
        /// <param name="obj">Die Daten.</param>
        /// <returns>Ein UIElement, das visuelles Feedback darstellt.</returns>
        UIElement GetVisualFeedback(IDataObject obj);

        /// <summary>
        /// Liefert den �bergeordneten Container.
        /// </summary>
        /// <returns>Das UIElement, welches den �bergeordneten Containr darstellt.</returns>
        UIElement GetTopContainer();

        /// <summary>
        /// Wird aufgerufen, wenn die Maus �ber der Drop-Zone bewegt wird (also nach OnEnterDropZone).
        /// </summary>
        /// <param name="obj">Die Daten.</param>
        /// <param name="dropPoint">Die Koordinaten des Drop-Punktes.</param>
        void OnDropQuery(IDataObject obj, Point dropPoint);

        /// <summary>
        /// Wird aufgerufen, wenn die Maus die Drop-Zone �ber dem Ziel-Element erreicht.
        /// </summary>
        /// <param name="obj">Die Daten.</param>
        void OnEnterDropZone(IDataObject obj);

        /// <summary>
        /// Wird aufgerufen, wenn die Maus die Drop-Zone �ber dem Ziel-Element verl��t.
        /// </summary>
        /// <param name="obj">Die Daten.</param>
        void OnLeaveDropZone(IDataObject obj);
    }
}
using System;

namespace Ex04.Menus.Events
{
    public delegate void ItemSelectedDelegate();
    public class ActionItem : MenuItem
    {
        // $G$ CSS-999 (-10) Class name should match the file name.
        public event ItemSelectedDelegate ItemSelected;

        public ActionItem(string i_Title) : base(i_Title)
        {
        }

        public override void Execute()
        {
            DoWhenSelected();
        }
        //$G$ CSS-027 (-10) Improper spacing.
        public void DoWhenSelected()
        {
            //$G$ DSN-003 (-3) Redundent method.
            OnSelection();
        }

        protected virtual void OnSelection()
        {
            if (ItemSelected != null)
            {
                ItemSelected.Invoke();
            }
            else
            {
                throw new NullReferenceException();
            }
        }
    }
}

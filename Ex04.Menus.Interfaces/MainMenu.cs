﻿
namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        // $G$ CSS-025 (-10) Improper spacing between signs.
        private Menu m_Menu=null;

        public MainMenu()
        {
        }
        public Menu Menu
        {
            get { return m_Menu; }
        }

        public void Show()
        {
            m_Menu.Execute();
        }

        public void Add(Menu i_MenuItem)
        {
            m_Menu=i_MenuItem;
        }
    }
}

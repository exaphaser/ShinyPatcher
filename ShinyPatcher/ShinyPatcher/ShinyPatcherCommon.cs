﻿using Microsoft.Win32;

namespace ZetaPatcher
{
    internal class ShinyPatcherCommon
    {

        public static string BrowseForSaveFile(string filter, string title)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = filter,
                Title = title
            };
            var showDialog = sfd.ShowDialog();
            if (showDialog != null && (bool) showDialog)
            {
                return sfd.FileName;
            }
            return null;
        }
        public static string BrowseForOpenFile(string filter, string title)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = filter,
                Title = title,
                Multiselect = false
            };
            var showDialog = ofd.ShowDialog();
            if (showDialog != null && (bool) showDialog)
            {
                return ofd.FileName;
            }
            return null;
        }
    }
}
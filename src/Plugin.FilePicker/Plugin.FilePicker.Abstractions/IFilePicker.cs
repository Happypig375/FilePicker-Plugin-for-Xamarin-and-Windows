﻿using System.Threading.Tasks;

namespace Plugin.FilePicker.Abstractions
{
    /// <summary>
    /// Interface for FilePicker
    /// </summary>
    public interface IFilePicker
    {
        Task<FileData> CreateFile ();

        Task<FileData> PickFile (string[] allowedTypes = null);

        Task<bool> SaveFile (FileData fileToSave);

        void OpenFile (string fileToOpen);

        void OpenFile (FileData fileToOpen);
    }
}
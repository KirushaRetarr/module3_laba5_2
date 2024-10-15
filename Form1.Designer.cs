using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace module3_laba5_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAW_BLEND = new Button();
            btnHOR_AW_SLIDE = new Button();
            btnCenter_AW_SLIDE = new Button();
            SuspendLayout();
            // 
            // btnAW_BLEND
            // 
            btnAW_BLEND.Location = new Point(30, 62);
            btnAW_BLEND.Name = "btnAW_BLEND";
            btnAW_BLEND.Size = new Size(232, 23);
            btnAW_BLEND.TabIndex = 0;
            btnAW_BLEND.Text = "Проявление";
            btnAW_BLEND.UseVisualStyleBackColor = true;
            btnAW_BLEND.Click += btnCenter_AW_SLIDE_Click;
            // 
            // btnHOR_AW_SLIDE
            // 
            btnHOR_AW_SLIDE.Location = new Point(30, 118);
            btnHOR_AW_SLIDE.Name = "btnHOR_AW_SLIDE";
            btnHOR_AW_SLIDE.Size = new Size(232, 23);
            btnHOR_AW_SLIDE.TabIndex = 1;
            btnHOR_AW_SLIDE.Text = "Горизонтальное появление";
            btnHOR_AW_SLIDE.UseVisualStyleBackColor = true;
            // 
            // btnCenter_AW_SLIDE
            // 
            btnCenter_AW_SLIDE.Location = new Point(30, 182);
            btnCenter_AW_SLIDE.Name = "btnCenter_AW_SLIDE";
            btnCenter_AW_SLIDE.Size = new Size(232, 23);
            btnCenter_AW_SLIDE.TabIndex = 2;
            btnCenter_AW_SLIDE.Text = "Появление из центра";
            btnCenter_AW_SLIDE.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 251);
            Controls.Add(btnCenter_AW_SLIDE);
            Controls.Add(btnHOR_AW_SLIDE);
            Controls.Add(btnAW_BLEND);
            Name = "Form1";
            Text = "Лабораторная 5";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAW_BLEND;
        private Button btnHOR_AW_SLIDE;
        private Button btnCenter_AW_SLIDE;
    }
}
namespace AnimatedWindow
{
    public class WinAPIClass
    {
    #region Анимация окна
    /// <summary>
    /// Тип анимации окна. Перечисление возвращает тип int
    /// после приведения. Каждому элементу присвоено
    /// свое значение типа int.
    /// </summary>
    [Flags]
    public enum AnimateWindowFlags : int
        {
            AW_HOR_POSITIVE = 1,
            AW_HOR_NEGATIVE = 2,
            AW_VER_POSITIVE = 4,
            AW_VER_NEGATIVE = 8,
            AW_CENTER = 16,
            AW_HIDE = 65536,
            AW_ACTIVATE = 131072,
            AW_SLIDE = 262144,
            AW_BLEND = 524288
        };
    /// <summary>
    /// Анимация окна.
    /// </summary>
    /// <param name="hwnd">Окно.</param>
    /// <param name="dwTime">Время.</param>
    /// <param name="dwFlags">Тип анимации. Если в
    /// неуправляемом коде используется перечисление, то его
    /// нужно конвертировать в тип данных int. </param>
    /// <returns></returns>
    [DllImportAttribute("user32.dll", EntryPoint = "AnimateWindow", SetLastError = true)]
        public static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);
        /// <summary>
        /// Анимация окна.
        /// </summary>
        /// <param name="ctrl">Окно.</param>
        /// <param name="dwTime">Время.</param>
        /// <param name="Flags">Флаги.</param>
        /// <returns></returns>
        public static bool AnimateWindow(Control ctrl, int dwTime,
        AnimateWindowFlags Flags)
        {
            return AnimateWindow(ctrl.Handle, dwTime, (int)Flags);
        }
        #endregion
    }
}
#pragma once

namespace Othello {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for MyForm
	/// </summary>
	public ref class MyForm : public System::Windows::Forms::Form
	{
	public:
		MyForm(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~MyForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::DataGridView^  dgv;
	private: System::Windows::Forms::MenuStrip^  menu;
	private: System::Windows::Forms::ToolStripMenuItem^  optionsToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  joueurVsJoueurToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  joueurVsIAToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  iAVsIAToolStripMenuItem;
	protected:


	protected:

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->dgv = (gcnew System::Windows::Forms::DataGridView());
			this->menu = (gcnew System::Windows::Forms::MenuStrip());
			this->optionsToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->joueurVsJoueurToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->joueurVsIAToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->iAVsIAToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dgv))->BeginInit();
			this->menu->SuspendLayout();
			this->SuspendLayout();
			// 
			// dgv
			// 
			this->dgv->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->dgv->Location = System::Drawing::Point(32, 55);
			this->dgv->Name = L"dgv";
			this->dgv->Size = System::Drawing::Size(240, 150);
			this->dgv->TabIndex = 0;
			// 
			// menu
			// 
			this->menu->Items->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(1) { this->optionsToolStripMenuItem });
			this->menu->Location = System::Drawing::Point(0, 0);
			this->menu->Name = L"menu";
			this->menu->Size = System::Drawing::Size(284, 24);
			this->menu->TabIndex = 1;
			this->menu->Text = L"menu";
			// 
			// optionsToolStripMenuItem
			// 
			this->optionsToolStripMenuItem->DropDownItems->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(3) {
				this->joueurVsJoueurToolStripMenuItem,
					this->joueurVsIAToolStripMenuItem, this->iAVsIAToolStripMenuItem
			});
			this->optionsToolStripMenuItem->Name = L"optionsToolStripMenuItem";
			this->optionsToolStripMenuItem->Size = System::Drawing::Size(61, 20);
			this->optionsToolStripMenuItem->Text = L"Options";
			// 
			// joueurVsJoueurToolStripMenuItem
			// 
			this->joueurVsJoueurToolStripMenuItem->Name = L"joueurVsJoueurToolStripMenuItem";
			this->joueurVsJoueurToolStripMenuItem->Size = System::Drawing::Size(161, 22);
			this->joueurVsJoueurToolStripMenuItem->Text = L"Joueur vs Joueur";
			// 
			// joueurVsIAToolStripMenuItem
			// 
			this->joueurVsIAToolStripMenuItem->Name = L"joueurVsIAToolStripMenuItem";
			this->joueurVsIAToolStripMenuItem->Size = System::Drawing::Size(161, 22);
			this->joueurVsIAToolStripMenuItem->Text = L"Joueur vs IA";
			// 
			// iAVsIAToolStripMenuItem
			// 
			this->iAVsIAToolStripMenuItem->Name = L"iAVsIAToolStripMenuItem";
			this->iAVsIAToolStripMenuItem->Size = System::Drawing::Size(161, 22);
			this->iAVsIAToolStripMenuItem->Text = L"IA vs IA";
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(284, 261);
			this->Controls->Add(this->dgv);
			this->Controls->Add(this->menu);
			this->MainMenuStrip = this->menu;
			this->Name = L"MyForm";
			this->Text = L"Othello";
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dgv))->EndInit();
			this->menu->ResumeLayout(false);
			this->menu->PerformLayout();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	};
}

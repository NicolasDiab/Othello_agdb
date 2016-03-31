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
	private: System::Windows::Forms::DataGridViewButtonColumn^  col1;
	private: System::Windows::Forms::DataGridViewButtonColumn^  col2;
	private: System::Windows::Forms::DataGridViewButtonColumn^  col3;
	private: System::Windows::Forms::DataGridViewButtonColumn^  col4;
	private: System::Windows::Forms::DataGridViewButtonColumn^  col5;
	private: System::Windows::Forms::DataGridViewButtonColumn^  col6;
	private: System::Windows::Forms::DataGridViewButtonColumn^  col7;
	private: System::Windows::Forms::DataGridViewButtonColumn^  col8;









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
			this->col1 = (gcnew System::Windows::Forms::DataGridViewButtonColumn());
			this->col2 = (gcnew System::Windows::Forms::DataGridViewButtonColumn());
			this->col3 = (gcnew System::Windows::Forms::DataGridViewButtonColumn());
			this->col4 = (gcnew System::Windows::Forms::DataGridViewButtonColumn());
			this->col5 = (gcnew System::Windows::Forms::DataGridViewButtonColumn());
			this->col6 = (gcnew System::Windows::Forms::DataGridViewButtonColumn());
			this->col7 = (gcnew System::Windows::Forms::DataGridViewButtonColumn());
			this->col8 = (gcnew System::Windows::Forms::DataGridViewButtonColumn());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dgv))->BeginInit();
			this->menu->SuspendLayout();
			this->SuspendLayout();
			// 
			// dgv
			// 
			this->dgv->AllowUserToDeleteRows = false;
			this->dgv->AllowUserToResizeColumns = false;
			this->dgv->AllowUserToResizeRows = false;
			this->dgv->BackgroundColor = System::Drawing::SystemColors::Window;
			this->dgv->BorderStyle = System::Windows::Forms::BorderStyle::None;
			this->dgv->CellBorderStyle = System::Windows::Forms::DataGridViewCellBorderStyle::None;
			this->dgv->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->dgv->ColumnHeadersVisible = false;
			this->dgv->Columns->AddRange(gcnew cli::array< System::Windows::Forms::DataGridViewColumn^  >(8) {
				this->col1, this->col2,
					this->col3, this->col4, this->col5, this->col6, this->col7, this->col8
			});
			this->dgv->Location = System::Drawing::Point(87, 27);
			this->dgv->Name = L"dgv";
			this->dgv->RowHeadersBorderStyle = System::Windows::Forms::DataGridViewHeaderBorderStyle::None;
			this->dgv->RowHeadersVisible = false;
			this->dgv->RowHeadersWidth = 20;
			this->dgv->ShowEditingIcon = false;
			this->dgv->Size = System::Drawing::Size(600, 600);
			this->dgv->TabIndex = 0;
			this->dgv->CellContentClick += gcnew System::Windows::Forms::DataGridViewCellEventHandler(this, &MyForm::dgv_CellContentClick);
			// 
			// menu
			// 
			this->menu->Items->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(1) { this->optionsToolStripMenuItem });
			this->menu->Location = System::Drawing::Point(0, 0);
			this->menu->Name = L"menu";
			this->menu->Size = System::Drawing::Size(784, 24);
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
			// col1
			// 
			this->col1->HeaderText = L"1";
			this->col1->Name = L"col1";
			// 
			// col2
			// 
			this->col2->HeaderText = L"2";
			this->col2->Name = L"col2";
			// 
			// col3
			// 
			this->col3->HeaderText = L"3";
			this->col3->Name = L"col3";
			// 
			// col4
			// 
			this->col4->HeaderText = L"4";
			this->col4->Name = L"col4";
			// 
			// col5
			// 
			this->col5->HeaderText = L"5";
			this->col5->Name = L"col5";
			// 
			// col6
			// 
			this->col6->HeaderText = L"6";
			this->col6->Name = L"col6";
			// 
			// col7
			// 
			this->col7->HeaderText = L"7";
			this->col7->Name = L"col7";
			// 
			// col8
			// 
			this->col8->HeaderText = L"8";
			this->col8->Name = L"col8";
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(784, 741);
			this->Controls->Add(this->dgv);
			this->Controls->Add(this->menu);
			this->MainMenuStrip = this->menu;
			this->Name = L"MyForm";
			this->Text = L"Othello";
			this->Load += gcnew System::EventHandler(this, &MyForm::MyForm_Load);
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dgv))->EndInit();
			this->menu->ResumeLayout(false);
			this->menu->PerformLayout();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void dgv_CellContentClick(System::Object^  sender, System::Windows::Forms::DataGridViewCellEventArgs^  e) {
	}
private: System::Void MyForm_Load(System::Object^  sender, System::EventArgs^  e) {
}
};
}

namespace Store
{
	public partial class Form2 : Form
	{
		int total;
		bool chnge = false;
		int count = 0;
		string itemInfoPath = @"..\..\..\ItemInfo.txt";
		string customerInfoPath= @"..\..\..\\CustomerInfo.txt";
		string localSellpath = @"..\..\..\\localsell.txt";
		string suppltSellPath = @"..\..\..\\supplySell.txt";
		int i,x,x2;
		public Form2()
		{
			InitializeComponent();
			total = 0;
			i = 0;
			transition.Text = " ";
			x= transition.Location.X;
			x2 = transition.Location.X;
			Icon.ImageLocation = @"C:\Users\Naveed Ahmed\Downloads\hd.jpg";
			Icon.SizeMode =PictureBoxSizeMode.StretchImage ;
			btnLocal.Cursor = Cursors.Hand;
			btnNewEntry.Cursor = Cursors.Hand;  
			btnSupply.Cursor = Cursors.Hand;
			btnStore.Cursor = Cursors.Hand;

			//Setting a image in circular shape
			System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
			gp.AddEllipse(0, 0, Icon.Width - 3, Icon.Height - 3);
			Region rg = new Region(gp);
			Icon.Region = rg;
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

	 

		private void btnNewEntry_Click(object sender, EventArgs e)
		{
		}

		private void Form2_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void Form2_BackColorChanged(object sender, EventArgs e)
		{

		}

	   
		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}


		private void Form2_FormClosing_1(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void btnLocal_Click_2(object sender, EventArgs e)
		{
			productNamesCbLocalPanel.Items.Clear();
			fillComBox(itemInfoPath,1,productNamesCbLocalPanel);
			removePanels();
			this.Controls.Add(this.LocalPanel2);
		}
	
		public void fillComBox(string path,int Index,ComboBox p)
		{
			string[] lines = File.ReadAllLines(@path);	
			foreach (string line in lines) 
			{
				string[] words=line.Split('$');
				p.Items.Add(words[Index]);
			}
		}

		private void btnShow_Click(object sender, EventArgs e)
		{ 
		}

		private void btnItem_Click(object sender, EventArgs e)
		{
			
		}

		private void btnSupply_Click_1(object sender, EventArgs e)
		{
			fillComBox(customerInfoPath, 1, CustomerNamecb);
			fillComBox(itemInfoPath, 1, productNamecb);
			removePanels();
			Controls.Add(SupplyPanel);

		}

		private void btnStore_Click_1(object sender, EventArgs e)
		{
			
			removePanels();
			Controls.Add(StorePanel);
		}
	    public void storeFillData(string path,string firstLine) 
		{
			string lineData = "";
			string[] lines = File.ReadAllLines(@path);
			ItemsDatalb.Items.Clear();
			ItemsDatalb.Items.Add(firstLine);
            foreach(string l in lines) 
			{
                for (int i=0;i<l.Length;i++) 
				{
                    if (l.ElementAt(i)=='$')
					{
						lineData += " | ";
					}
                    else
                    {
						lineData += l.ElementAt(i);
                    }
				}
				ItemsDatalb.Items.Add(lineData);
				lineData = "";
			}
		}
		private void Form2_Load(object sender, EventArgs e)
		{
			timer1.Start();

		}
		private void button1_Click(object sender, EventArgs e)
		{
		   
		}
		private void btnNewEntry_Click_1(object sender, EventArgs e)
		{
			namesCBAddpanel.Items.Clear();
			fillComBox(itemInfoPath, 1, namesCBAddpanel);
			removePanels();
			Controls.Add(AddPanel);
		}

		private void SupplyPanel_Paint(object sender, PaintEventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void LocalPanel_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void Searchtb_TextChanged(object sender, EventArgs e)
		{

		}

		private void printButtonLocalPanel_Click(object sender, EventArgs e)
		{
		  
			printDataLocalPanel.Text ="Name : "+CustomerNameLocalPaneltb.Text+"\r\n";
			
			
		}
		private void removePanels() 
		{
			foreach (Control c in Controls)
			{
				if (c is Panel)
				{
					Panel p = c as Panel;
					bool b = true;
					if (p.Name == "panel1")
					{
						b = false;
					}
					else if (p.Name == "panel2")
					{
						b = false;
					}
					else if (p.Name=="panel18") 
					{
						b = false;
					}
					if (b)
					{
						Controls.Remove(c);
					}
				}
			}
		   
		}

		private void EnteryPanel_Paint(object sender, PaintEventArgs e)
		{

		}

		private void Form2_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode==Keys.LControlKey) 
			{
				MessageBox.Show("Key successful");
;            }
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			FileInfo file = new FileInfo(suppltSellPath);
			int primery = primeryKey(file);
			StreamWriter sw = file.AppendText();
			string line="";
			int quantity = 0;
			if (displayProducts.Text.Length != 0)
			{
				MessageBox.Show("Change made to database" + displayProducts.Text);
			}
			else
			{
				try
				{
					quantity = int.Parse(Quantitytb.Text);
					line = primery + "$" + CustomerNamecb.Text + "$" + productNamecb.Text + "$" + quantity + "\n";
					sw.Write(line);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Enter Quantity in number");
				}
				sw.Close();
				ChangeInFile(itemInfoPath, productNamecb, productNamecb.SelectedIndex, "sell", quantity);
			}
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnAddItem_Click(object sender, EventArgs e)
		{
			FileInfo file= new FileInfo(itemInfoPath);
			int primery = primeryKey(file);
            if (productNameTextBoxAddPanel.Text.Length!=0 && quantitytextBoxAddPanel.Text.Length!=0 && itemPriceAddPanel.Text.Length==0) 
			{
				int quantity = int.Parse(quantitytextBoxAddPanel.Text);
				ChangeInFile(itemInfoPath, namesCBAddpanel,namesCBAddpanel.SelectedIndex,"add",quantity);
			}
			else if (productNameTextBoxAddPanel.Text.Length != 0 && quantitytextBoxAddPanel.Text.Length != 0 && itemPriceAddPanel.Text.Length != 0)
			{
				try
				{
					int quantity = int.Parse(quantitytextBoxAddPanel.Text);
					int price = int.Parse(itemPriceAddPanel.Text);
					StreamWriter sw = file.AppendText();
					sw.WriteLine(primery + "$" + productNameTextBoxAddPanel.Text + "$" + quantitytextBoxAddPanel.Text + "$" + itemPriceAddPanel.Text);
					sw.Close();
					MessageBox.Show("Product has been saved");
				}
				catch(Exception ex) 
				{
					MessageBox.Show("Please enter Quantity and Price in 1223 form");
				}
			}
            else 
			{
				MessageBox.Show("Invalid operations");
			}

		}

		public void ChangeInFile(string path, ComboBox cb, int lineNo, string change, int quatity)
		{
			int LineNo = cb.SelectedIndex;
			string[] lines = File.ReadAllLines(@path);
			string[] words = (lines[LineNo]).Split("$");
			if (change.Equals("sell"))
			{
				int avaiblabeQuantity = int.Parse(words[2]);
				if (quatity > avaiblabeQuantity)
				{
					MessageBox.Show("Out of Stock"+"Available"+avaiblabeQuantity);
					chnge =false;
				}
				else
				{
					MessageBox.Show("Change has been made");
					quatity = int.Parse(words[2]) - quatity;
					words[2] = quatity + "";
					lines[LineNo] = words[0] + "$" + words[1] + "$" + words[2] + "$" + words[3];
					File.WriteAllLines(@path, lines);
					chnge = true;
				}
			}
			else if (change.Equals("add"))
			{
				MessageBox.Show("Added");
				quatity = int.Parse(words[2]) + quatity;
				words[2] = quatity + "";
				lines[LineNo] = words[0] + "$" + words[1] + "$" + words[2] + "$" + words[3];
				File.WriteAllLines(@path, lines);
			}
            else 
			{
				MessageBox.Show("Invalid operation");
			}
		}

		public int primeryKey(FileInfo file) 
		{
			int count = 1;
			StreamReader sr = file.OpenText();
			while (sr.ReadLine()!=null) 
			{
				count++;
			}
			sr.Close();
			return count;
			
		}
		private void btnAddCustomer_Click(object sender, EventArgs e)
		{
			FileInfo file = new FileInfo(customerInfoPath);
			int primery = primeryKey(file);
			StreamWriter sw = file.AppendText();
			if ((cusNameAddPanel.Text.Length!=null)&&(phoneAddPanel.Text.Length != null)&&(AddreestbAddPanel.Text.Length != null)&&(shopNametextBoxAddPanel.Text.Length != null)) 
			{
				sw.Write("\n"+primery+"$"+cusNameAddPanel.Text+"$"+ phoneAddPanel.Text+"$"+ shopNametextBoxAddPanel.Text);
				MessageBox.Show(primery + "$" + cusNameAddPanel.Text + "$" + phoneAddPanel.Text + "$" + shopNametextBoxAddPanel.Text);
			}
			else 
			{
				MessageBox.Show("Please Enter data corrently");
			}
			sw.Close();
		}

		private void printButtonLocalPanel_Click_1(object sender, EventArgs e)
		{
			FileInfo file = new FileInfo(localSellpath);

			printDataLocalPanel.Text += "\r\n\r\nTotal Price........" + total;
			

		}
		public int itemPrice(string path,int lineNo) 
		{
			string[] lines = File.ReadAllLines(@path);
			string[] words = (lines[lineNo]).Split("$");
			int price = int.Parse(textBox1.Text.Trim()) * int.Parse(words[3].Trim());
			total += price;
			return price;

		}
		public void print() 
		{
			count++;
			int price= itemPrice(itemInfoPath, productNamesCbLocalPanel.SelectedIndex);
			printDataLocalPanel.Text += "\r\n" + count + "\r\n" + "Item Name" + productNamesCbLocalPanel.Text +
						"\r\nItem Price " + price;
		}
        private void AddAnotherItem_Click(object sender, EventArgs e)
		{
			FileInfo file = new FileInfo(localSellpath);
			int primery = primeryKey(file);
			int quantity = int.Parse((textBox1.Text).Trim());
			chnge = false;
			ChangeInFile(itemInfoPath, productNamesCbLocalPanel, productNamesCbLocalPanel.SelectedIndex,"sell",quantity);
			StreamWriter sw = file.AppendText();
			if (chnge == true && productNamesCbLocalPanel.Text.Length!=0 && textBox1.Text.Length!=0)
			{
				sw.Write(primery+"$"+productNamesCbLocalPanel.Text+"$"+textBox1.Text+"$"+CustomerNameLocalPaneltb.Text+"\r\n");
				print();
				productNamesCbLocalPanel.Text = "";
				textBox1.Text = "";
				CustomerNamecb.Text = "";
			}
			sw.Close();
		}

        private void btnAddMore_Click(object sender, EventArgs e)
        {
			FileInfo file = new FileInfo(suppltSellPath);
			int primery = primeryKey(file);
			StreamWriter sw = file.AppendText();
			string line = "";
			int quantity = 0;
			if (CustomerNamecb.Text.Length != 0 && productNamecb.Text.Length != 0 && Quantitytb.Text.Length != 0)
			{
				try
				{
					quantity = int.Parse(Quantitytb.Text);
					line = primery + "$" + CustomerNamecb.Text + "$" + productNamecb.Text + "$" + quantity + "\n";
					ChangeInFile(itemInfoPath, productNamecb, productNamecb.SelectedIndex, "sell", quantity);
                    
					if (chnge==true) 
					{
						sw.Write(line);
					    displayProducts.Text += productNamecb.Text + " " + Quantitytb.Text + "\r\n";
					    productNamecb.Text = "";
					    CustomerNamecb.Text = "";
					    Quantitytb.Text = "";
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Enter Quantity in number i.e 123");
				}
				sw.Close();
			}
		}
        private void namesCBAddpanel_SelectedIndexChanged(object sender, EventArgs e)
        {
			productNameTextBoxAddPanel.Text=namesCBAddpanel.Text;
			for(int i = 0; i < 1000; i++) 
			{
				quantityComboBox.Items.Add(i);
			}
        }

        private void quantityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
			quantitytextBoxAddPanel.Text=quantityComboBox.Text;	
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
			storeFillData(itemInfoPath,"ItemNo-Name-Quantiy-Price");
		}

        private void button2_Click(object sender, EventArgs e)
        {
			storeFillData(customerInfoPath, "CusId$CName$Phne$ShpNm$Addr");
		}

        private void button3_Click(object sender, EventArgs e)
        {
			storeFillData(localSellpath,"itemNo-ProN-Quantity");
        }

        private void button4_Click(object sender, EventArgs e)
        {
			storeFillData(suppltSellPath, "itemNo-CusN-ProN-Quan");
		}

        private void btnClear_Click(object sender, EventArgs e)
        {
			productNamecb.Text = "";
			CustomerNamecb.Text = "";
			Quantitytb.Text = "";
		}
		private void timer1_Tick(object sender, EventArgs e)
		{

			string str = "بِسْمِ اللَّهِ الرَّحْمَنِ الرَّحِيم";
			//string str = "Store Nuadero";
			if (i != str.Length)
			{
				x -= 25;
				transition.Location=new Point(x,0); 
				transition.Text += str.ElementAt(i);
				i++;
			}
		   
			else
			{
				i = 0;
				x = x2;
				transition.Text = " ";
			}
		}
	}
}

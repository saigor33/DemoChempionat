using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace myTest_app
{
    public partial class form_construct : Form
    {
        Graphics gr;
        Bitmap bmp;
        float widthValue = 0 ;
        float heightValue = 0;
        float angleValue =0;

        List<PaintedObject> listObj; //список с обектами для прорисовки
        PaintedObject currentObj; //выбранныей объект
        Point startPoint;
        int modJob = 1;
        private const int MOD_DRAW = 1;
        private const int MOD_MOVE = 2;
        private const int MOD_EDIT = 3;

        private const string COLOR_ORANGE = "Оранжевый";
        private const string COLOR_YELLOW = "Жёлтый";
        private const string COLOR_GREEN = "Зелёный";
        private const string COLOR_LIGHT_BLUE = "Светло-синий";

        private const string COLOR_RED = "Красный";
        private const string COLOR_PURPLE = "Лиловый";
        private const string COLOR_GRAY = "Серый";
        private const string COLOR_BLUE = "Синий";

        /* private const string MATERIAL_COTTON = "хлопок";
         private const string MATERIAL_SILK = "шёлк";
         private const string MATERIAL_COTTON = "хлопок";
         private const string MATERIAL_COTTON = "хлопок";*/


        public form_construct()
        {
            InitializeComponent();
            bmp = new Bitmap(pBox_img.Width, pBox_img.Height);
            listObj = new List<PaintedObject>();
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form_construct_Load(object sender, EventArgs e)
        {
            cbox_material.Items.Clear();

            lvl_postValue.Text = userData.userPost;
            string sql_query = "select distinct rulons_composition from rulons";
            DataSet data = new DataSet();
            data = databaseConnect.select_dbAllTable(sql_query, "rulons");
            for (int i = 0; i < data.Tables[0].Rows.Count; i++)
            {
                cbox_material.Items.Add(data.Tables[0].Rows[i][0]);
            }
            angleValue =(float) nUpd_rotation.Value;
            widthValue = (float)nUpd_lenght.Value;
            heightValue = (float)nUpd_height.Value;
            // cbox_material.Text = "Выбирите материал";



        }


        private void pBox_img_MouseClick(object sender, MouseEventArgs e)
        {
            switch (modJob)
            {
                case MOD_DRAW:
                    {
                        int x = e.X;
                        int y = e.Y;
                        // MessageBox.Show(x + " " + y);
                        PaintedObject po = new PaintedObject(new Pen(color), new GraphicsPath());
                        po.Path.AddRectangle(new Rectangle(x, y, (int) widthValue, (int) heightValue));
                        po.Color = color;
                        po.Composition = composition;
                        po.Rotation = angleValue;
                        po.Width = widthValue;
                        po.Height = heightValue;
                        po.Location = e.Location;

                        po.Path.Transform(setAngleRotation(po.Rotation, po.Location, po.Width, po.Height ));
                        // showMessage(po.Color.ToString() + "" + po.Composition.ToString());
                        //listObj.Add(po); 

                        //Добавления элемента в начала списка, чтобы элементы маленького размера
                        // можно было подхватить. В алгоритме выбирается первый встречающийся по списку
                        listObj.Insert(0, po);
                        referechDrawObj();
                        // Color col = Color.FromName(cbox_color.Text);
                        break;

                    }
                case MOD_EDIT:
                    {
                        
                        foreach (PaintedObject po in listObj)
                        {
                            if (po.Path.GetBounds().Contains(e.Location))
                            {
                                if (currentObj != null && currentObj.Path != null)
                                    currentObj.Pen.Width -= 1;
                                //currentObj.Pen.Width -= 1;
                                currentObj = po;

                                currentObj.Pen.Width += 1;
                                referechDrawObj();

                                return;
                            }
                        }
                        break;
                    }
            }
        }




        private void pBox_img_MouseDown(object sender, MouseEventArgs e)
        {
            switch (modJob)
            {
                case MOD_MOVE:
                    {
                        startPoint = e.Location;
                        foreach (PaintedObject po in listObj)
                        {
                            if (po.Path.GetBounds().Contains(e.Location))
                            {
                                currentObj = po;
                                currentObj.Pen.Width += 1;
                                //со swith не работет
                                if (currentObj.Color == Color.Green)
                                {
                                    cbox_color.Text = COLOR_GREEN;
                                }

                                if (currentObj.Color == Color.Yellow)
                                {
                                    cbox_color.Text = COLOR_YELLOW;
                                }

                                if (currentObj.Color == Color.LightBlue)
                                {
                                    cbox_color.Text = COLOR_LIGHT_BLUE;
                                }

                                if (currentObj.Color == Color.Orange)
                                {
                                    cbox_color.Text = COLOR_ORANGE;
                                }

                                if (currentObj.Color == Color.Red)
                                {
                                    cbox_color.Text = COLOR_RED;
                                }

                                if (currentObj.Color == Color.Blue)
                                {
                                    cbox_color.Text = COLOR_BLUE;
                                }

                                if (currentObj.Color == Color.Gray)
                                {
                                    cbox_color.Text = COLOR_GRAY;
                                }

                                if (currentObj.Color == Color.Purple)
                                {
                                    cbox_color.Text = COLOR_PURPLE;
                                   // cbox_color.SelectedItem = COLOR_PURPLE;
                                    // cbox_color.sele
                                    //showMessage("COLOR_PURPLE");
                                }


                                cbox_material.Text = currentObj.Composition;
                            return;
                            }

                        }
                        break;
                    }
            }
        }

        private void pBox_img_MouseUp(object sender, MouseEventArgs e)
        {
            switch (modJob)
            {
                case MOD_MOVE:
                    {
                        if (currentObj != null)
                        {
                            currentObj.Pen.Width -= 1;
                            currentObj = null;
                        }
                        break;
                    }
            }
        }

        private void pBox_img_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_pointMouse.Text = e.Location.ToString();
            switch (modJob)
            {
                case MOD_MOVE:
                    {
                        switch (e.Button)
                        {
                            case MouseButtons.Left:
                                {
                                    int deltaX = e.Location.X - startPoint.X;
                                    int deltaY = e.Location.Y - startPoint.Y;
                                    //смещаем фигуру
                                    //два if это костыльчик. Выручают от вылета из программы
                                    if (currentObj != null)
                                    {
                                        if (currentObj.Path != null)
                                        {
                                            currentObj.Path.Transform(new Matrix(1, 0, 0, 1, deltaX, deltaY));
                                            referechDrawObj();

                                        }
                                    }
                                    startPoint = e.Location;

                                    break;
                                }
                            default:
                                {
                                    break;
                                }
                        }
                        break;
                    }
            }
        }
        private void referechDrawObj()
        {
            if (bmp != null)
                bmp.Dispose();
            bmp = new Bitmap(pBox_img.Width, pBox_img.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                foreach (PaintedObject po in listObj)
                {
                    // po.Path.Transform(setAngleRotation(po.Rotation, po.Path.GetBounds()));
                    g.DrawPath(po.Pen, po.Path);
                    
                   // showMessage(po.Color.ToString());
                }
                pBox_img.Image = bmp;
            }
        }

        Color color;
        string composition;
        private void btn_newPropertiesObj_Click(object sender, EventArgs e)
        {
            if (cbox_material.Text != "")
            {
                composition = cbox_material.Text;
            }
            else
            {
                showMessage("Вы не выбрали материал");
                return;
            }

            if (cbox_color.Text != "")
            {
                switch (cbox_color.Text)
                {
                    case COLOR_GREEN:
                        {
                            color = Color.Green;
                            break;
                        }
                    case COLOR_LIGHT_BLUE:
                        {
                            color = Color.LightBlue;
                            break;
                        }
                    case COLOR_ORANGE:
                        {
                            color = Color.Orange;
                            break;

                        }
                    case COLOR_YELLOW:
                        {
                            color = Color.Yellow;
                            break;
                        }
                    case COLOR_BLUE:
                        {
                            color = Color.Blue;
                            break;
                        }
                    case COLOR_GRAY:
                        {
                            color = Color.Gray;
                            break;
                        }
                    case COLOR_PURPLE:
                        {
                            color = Color.Purple;
                            break;
                        }
                    case COLOR_RED:
                        {
                            color = Color.Red;
                            break;
                        }
                    default:
                        {
                            showMessage("Выбранные цвет в данный момент недостпен. \n Обратитесь к менеджеру");
                            return;
                        }
                }
            }
            /* float width;
             float height;
             if (float.TryParse(textBox_width.Text, out width))
             {
                 if (width > 0)
                 {
                     widthValue = width;
                 }
                 else
                 {
                     showMessage("Длинна не может быть отрицательной");
                     return;
                 }
             }
             else
             {
                 showMessage("В поле длинна присутсвуют посторонние символы");
                 return;
             }
             if (float.TryParse(textBox_height.Text, out height))
             {
                 if (height > 0)
                 {
                     heightValue = height;
                 }
                 else
                 {
                     showMessage("Ширина не может быть отрицательной");
                     return;
                 }
             }
             else
             {
                 showMessage("В поле ширина присутсвуют посторонние символы");
                 return;
             }
             */
            widthValue = (float)nUpd_lenght.Value;
            heightValue = (float)nUpd_height.Value;
            switch (modJob)
            {
                // case MOD
                case MOD_EDIT:
                    {
                        if (currentObj != null && currentObj.Path != null)
                        {
                            // Matrix matr = new Matrix();
                            //RectangleF rect = currentObj.Path.GetBounds();
                            //  MessageBox.Show(rect.ToString());
                            // rect.Width = widthValue;
                            //rect.Height = heightValue;
                            currentObj.Composition = composition;
                            currentObj.Width = widthValue;
                            currentObj.Height = heightValue;
                            currentObj.Color = color;
                            currentObj.Rotation = angleValue;
                            currentObj.Pen = new Pen(color);
                            //Matrix matrr = new Matrix();
                            currentObj.Path.Reset();
                            currentObj.Path.AddRectangle(new RectangleF(currentObj.Location.X, currentObj.Location.Y, currentObj.Width, currentObj.Height));
                           // currentObj.Path.AddRectangle(rect);
                            // angleValue = (float)numUpd_rotation.Value;
                            //float deltaRation = currentObj.Rotation ; //получаем значение разницы поворота- angleValue
                            // currentObj.Path.Transform()
                           currentObj.Path.Transform(setAngleRotation(currentObj.Rotation, currentObj.Location, currentObj.Width, currentObj.Height)); //поворачиваем фигуру
                            //currentObj.Path.
                            referechDrawObj();
                        }
                        break;
                    }
            }

        }
        public void showMessage(string str)
        {
            MessageBox.Show(str);
        }

        private void rbtn_draw_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_draw.Checked)
                modJob = MOD_DRAW;
        }

        private void rbtn_hand_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_hand.Checked)
                modJob = MOD_MOVE;
        }

        private void rbt_edit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_edit.Checked)
                modJob = MOD_EDIT;
        }

        private void btn_deleteObj_Click(object sender, EventArgs e)
        {
            if (rbt_edit.Checked)
            {
                listObj.Remove(currentObj);
                referechDrawObj();
            }
        }

        private void cbox_color_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_newPropertiesObj_Click(this, new EventArgs());
        }

        private void cbox_material_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbox_color.Items.Clear();
            cbox_color.Visible = true;
            lbl_color.Visible = true;
            string sql_query = "select distinct rulons_color from rulons where rulons_composition ='" + cbox_material.Text + "';";
            DataSet data = databaseConnect.select_dbAllTable(sql_query, "rulons");
            for (int i = 0; i < data.Tables[0].Rows.Count; i++)
            {
                cbox_color.Items.Add(data.Tables[0].Rows[i][0]);
            }
            btn_newPropertiesObj_Click(this, new EventArgs());
            //cbox_color.Text= "Выбирите цвет";

        }

        private void pBox_img_Click(object sender, EventArgs e)
        {

        }

        private void nUpd_lenght_ValueChanged(object sender, EventArgs e)
        {
            btn_newPropertiesObj_Click(this, new EventArgs());
        }

        private void nUpd_height_ValueChanged(object sender, EventArgs e)
        {
            btn_newPropertiesObj_Click(this, new EventArgs());
        }

        private Matrix setAngleRotation (float angle, Point pointLocal, float width, float height)
        {
            float pointX = pointLocal.X + width / 2;
            float pointY = pointLocal.Y + height / 2;

            Matrix matrRotation = new Matrix();
            matrRotation.RotateAt(angle, new PointF(pointX, pointY)); //, new PointF (pointX, pointY)
            //matrRotation.RotateAt()
            return matrRotation;
        }

        private void numUpd_rotation_ValueChanged(object sender, EventArgs e)
        {
             angleValue = (float)nUpd_rotation.Value;
            btn_newPropertiesObj_Click(this, new EventArgs());
        }
    }
}

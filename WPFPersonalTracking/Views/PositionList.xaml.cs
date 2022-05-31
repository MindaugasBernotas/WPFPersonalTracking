using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFPersonalTracking.ViewModels;

namespace WPFPersonalTracking.Views
{
    /// <summary>
    /// Interaction logic for PositionList.xaml
    /// </summary>
    public partial class PositionList : UserControl
    {
        public PositionList()
        {
            InitializeComponent();
        }
        PersonalTrackingContext db = new PersonalTrackingContext();
        private object modellist;

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            var list = db.Positions.Include(x => x.Department).Select(a => new
            {
                positionId=a.Id,
                PositionName=a.PositionName,
                departmentId=a.DepartmentId,
                departmentName=a.DepartmentName
                }).OrderBy(x=>x.PositionName).ToList();
                List<PositionModel> model = new PositionModel();
            foreach (var item in list)
            {
                PositionModel model = new PositionModel();
                model.Id = item.positionId;
                model.PositionName = item.PositionName;
                model.DepartmentName = item.departmentName;
                model.DepartmentId = item.departmentId;
                modellist.Add(model);
            }
            gridPosition.ItemsSource = modellist;
        }
    }
}

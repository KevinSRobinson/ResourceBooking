Partial Class BookingReport
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim TableGroup1 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup2 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup3 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup4 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookingReport))
        Dim TableGroup5 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup6 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule5 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule6 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector1 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule7 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector2 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.labelsGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.labelsGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.Table2 = New Telerik.Reporting.Table()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox22 = New Telerik.Reporting.TextBox()
        Me.titleTextBox = New Telerik.Reporting.TextBox()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.Shape2 = New Telerik.Reporting.Shape()
        Me.Shape1 = New Telerik.Reporting.Shape()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        Me.Table1 = New Telerik.Reporting.Table()
        Me.TextBox23 = New Telerik.Reporting.TextBox()
        Me.sqlResources = New Telerik.Reporting.SqlDataSource()
        Me.TextBox24 = New Telerik.Reporting.TextBox()
        Me.TextBox25 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.Cost = New Telerik.Reporting.SqlDataSource()
        Me.Table3 = New Telerik.Reporting.Table()
        Me.TextBox26 = New Telerik.Reporting.TextBox()
        Me.TextBox27 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TextBox11
        '
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0000002384185791R), Telerik.Reporting.Drawing.Unit.Cm(0.74999988079071045R))
        Me.TextBox11.Style.BackgroundColor = System.Drawing.Color.Gray
        Me.TextBox11.Style.Font.Bold = True
        Me.TextBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(16.0R)
        Me.TextBox11.StyleName = "Office.TableHeader"
        Me.TextBox11.Value = "Booking ID"
        '
        'TextBox3
        '
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.0999999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.55562496185302734R))
        Me.TextBox3.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TextBox3.Style.Font.Bold = True
        Me.TextBox3.Value = "Resources"
        '
        'labelsGroupFooterSection
        '
        Me.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155R)
        Me.labelsGroupFooterSection.Name = "labelsGroupFooterSection"
        Me.labelsGroupFooterSection.Style.Visible = False
        '
        'labelsGroupHeaderSection
        '
        Me.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155R)
        Me.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection"
        Me.labelsGroupHeaderSection.PrintOnEveryPage = True
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "My.Reports.My.MySettings.ResourceBookingCalendar"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@ClassID", System.Data.DbType.Int16, "=Parameters.ClassID.Value")})
        Me.SqlDataSource1.SelectCommand = "SELECT     ResourceBookings.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         ResourceBookings" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE ClassID = @Cl" & _
    "assID "
        '
        'reportHeader
        '
        Me.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(2.0529167652130127R)
        Me.reportHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Table2, Me.TextBox22})
        Me.reportHeader.Name = "reportHeader"
        '
        'Table2
        '
        Me.Table2.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(3.0000002384185791R)))
        Me.Table2.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.74999988079071045R)))
        Me.Table2.Body.SetCellContent(0, 0, Me.TextBox12)
        TableGroup1.ReportItem = Me.TextBox11
        Me.Table2.ColumnGroups.Add(TableGroup1)
        Me.Table2.DataSource = Me.SqlDataSource1
        Me.Table2.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox12, Me.TextBox11})
        Me.Table2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.19416671991348267R))
        Me.Table2.Name = "Table2"
        TableGroup2.Groupings.Add(New Telerik.Reporting.Grouping(Nothing))
        TableGroup2.Name = "Detail"
        Me.Table2.RowGroups.Add(TableGroup2)
        Me.Table2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0000002384185791R), Telerik.Reporting.Drawing.Unit.Cm(1.4999997615814209R))
        Me.Table2.Style.Visible = True
        Me.Table2.StyleName = "Office.TableNormal"
        '
        'TextBox12
        '
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0000002384185791R), Telerik.Reporting.Drawing.Unit.Cm(0.74999988079071045R))
        Me.TextBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(16.0R)
        Me.TextBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox12.Value = "=Fields.ClassID"
        '
        'TextBox22
        '
        Me.TextBox22.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R), Telerik.Reporting.Drawing.Unit.Cm(0.19416671991348267R))
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.5806245803833008R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.TextBox22.Style.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TextBox22.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(24.0R)
        Me.TextBox22.Value = "Booking Report"
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.814167022705078R), Telerik.Reporting.Drawing.Unit.Cm(2.0R))
        Me.titleTextBox.StyleName = "Title"
        Me.titleTextBox.Value = "Booking Report"
        '
        'reportFooter
        '
        Me.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155R)
        Me.reportFooter.Name = "reportFooter"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(8.8327083587646484R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Shape2, Me.Shape1, Me.TextBox1, Me.TextBox2, Me.TextBox5, Me.TextBox6, Me.TextBox7, Me.TextBox8, Me.TextBox9, Me.TextBox13, Me.TextBox14, Me.TextBox15, Me.TextBox16, Me.TextBox17, Me.TextBox18, Me.TextBox19, Me.TextBox20, Me.TextBox21, Me.Table1, Me.TextBox24, Me.TextBox25, Me.Table3})
        Me.detail.Name = "detail"
        '
        'Shape2
        '
        Me.Shape2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.6000003814697266R), Telerik.Reporting.Drawing.Unit.Cm(4.0327081680297852R))
        Me.Shape2.Name = "Shape2"
        Me.Shape2.ShapeType = New Telerik.Reporting.Drawing.Shapes.PolygonShape(4, 45.0R, 0)
        Me.Shape2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.8999996185302734R), Telerik.Reporting.Drawing.Unit.Cm(3.5000002384185791R))
        Me.Shape2.Stretch = True
        '
        'Shape1
        '
        Me.Shape1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.30000004172325134R), Telerik.Reporting.Drawing.Unit.Cm(4.0327081680297852R))
        Me.Shape1.Name = "Shape1"
        Me.Shape1.ShapeType = New Telerik.Reporting.Drawing.Shapes.PolygonShape(4, 45.0R, 0)
        Me.Shape1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.6999993324279785R), Telerik.Reporting.Drawing.Unit.Cm(3.5000002384185791R))
        Me.Shape1.Stretch = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.3999998569488525R), Telerik.Reporting.Drawing.Unit.Cm(1.3327081203460693R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.4000000953674316R), Telerik.Reporting.Drawing.Unit.Cm(0.70000004768371582R))
        Me.TextBox1.Value = "=Fields.Subject"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.3999998569488525R), Telerik.Reporting.Drawing.Unit.Cm(2.2327079772949219R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.40000057220459R), Telerik.Reporting.Drawing.Unit.Cm(1.5000008344650269R))
        Me.TextBox2.Value = "=Fields.Description"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.5999999046325684R), Telerik.Reporting.Drawing.Unit.Cm(5.52687406539917R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.9999997615814209R), Telerik.Reporting.Drawing.Unit.Cm(0.69999927282333374R))
        Me.TextBox5.Value = "=Fields.TeaCoffeeTime"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.5999999046325684R), Telerik.Reporting.Drawing.Unit.Cm(4.6268744468688965R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.9999997615814209R), Telerik.Reporting.Drawing.Unit.Cm(0.69999927282333374R))
        Me.TextBox6.Value = "=iif(Fields.TeaCoffee = true, ""Yes"", ""No"")"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.599998950958252R), Telerik.Reporting.Drawing.Unit.Cm(6.4268741607666016R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0R), Telerik.Reporting.Drawing.Unit.Cm(0.69999760389328R))
        Me.TextBox7.Value = "=Fields.NoPeople"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.30000004172325134R), Telerik.Reporting.Drawing.Unit.Cm(1.332708477973938R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0R), Telerik.Reporting.Drawing.Unit.Cm(0.69999963045120239R))
        Me.TextBox8.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TextBox8.Style.Color = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.TextBox8.Style.Font.Bold = True
        Me.TextBox8.Value = "Booking"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.30000004172325134R), Telerik.Reporting.Drawing.Unit.Cm(2.23270845413208R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0R), Telerik.Reporting.Drawing.Unit.Cm(0.69999963045120239R))
        Me.TextBox9.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TextBox9.Style.Font.Bold = True
        Me.TextBox9.Value = "Description"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.39687499403953552R), Telerik.Reporting.Drawing.Unit.Cm(4.6268744468688965R))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0R), Telerik.Reporting.Drawing.Unit.Cm(0.69999963045120239R))
        Me.TextBox13.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TextBox13.Style.Font.Bold = True
        Me.TextBox13.Value = "Tea Coffee"
        '
        'TextBox14
        '
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.39687499403953552R), Telerik.Reporting.Drawing.Unit.Cm(5.52687406539917R))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0R), Telerik.Reporting.Drawing.Unit.Cm(0.69999963045120239R))
        Me.TextBox14.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TextBox14.Style.Font.Bold = True
        Me.TextBox14.Value = "Tea Coffee Time"
        '
        'TextBox15
        '
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.40000000596046448R), Telerik.Reporting.Drawing.Unit.Cm(6.4268732070922852R))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0R), Telerik.Reporting.Drawing.Unit.Cm(0.69999963045120239R))
        Me.TextBox15.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TextBox15.Style.Font.Bold = True
        Me.TextBox15.Value = "No of People"
        '
        'TextBox16
        '
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.0R), Telerik.Reporting.Drawing.Unit.Cm(6.3327083587646484R))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.9999988079071045R), Telerik.Reporting.Drawing.Unit.Cm(0.70020109415054321R))
        Me.TextBox16.Value = "=Fields.RoomStyle"
        '
        'TextBox17
        '
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.0R), Telerik.Reporting.Drawing.Unit.Cm(4.63270902633667R))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.9999995231628418R), Telerik.Reporting.Drawing.Unit.Cm(0.70000088214874268R))
        Me.TextBox17.Value = "=iif(Fields.EveningBooking = true, 'Yes', 'No')"
        '
        'TextBox18
        '
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.0R), Telerik.Reporting.Drawing.Unit.Cm(5.4327082633972168R))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.9999988079071045R), Telerik.Reporting.Drawing.Unit.Cm(0.69999927282333374R))
        Me.TextBox18.Value = "=Fields.BookingLength"
        '
        'TextBox19
        '
        Me.TextBox19.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(4.6268744468688965R))
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0R), Telerik.Reporting.Drawing.Unit.Cm(0.69999963045120239R))
        Me.TextBox19.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TextBox19.Style.Font.Bold = True
        Me.TextBox19.Value = "Booking Length"
        '
        'TextBox20
        '
        Me.TextBox20.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(5.4531254768371582R))
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0R), Telerik.Reporting.Drawing.Unit.Cm(0.69999963045120239R))
        Me.TextBox20.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TextBox20.Style.Font.Bold = True
        Me.TextBox20.Value = "Room Style"
        '
        'TextBox21
        '
        Me.TextBox21.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(6.35312557220459R))
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0R), Telerik.Reporting.Drawing.Unit.Cm(0.69999963045120239R))
        Me.TextBox21.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TextBox21.Style.Font.Bold = True
        Me.TextBox21.Value = "Evening Booking"
        '
        'Table1
        '
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(4.0999999046325684R)))
        Me.Table1.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.60854184627532959R)))
        Me.Table1.Body.SetCellContent(0, 0, Me.TextBox23)
        TableGroup3.Name = "tableGroup"
        TableGroup3.ReportItem = Me.TextBox3
        Me.Table1.ColumnGroups.Add(TableGroup3)
        Me.Table1.DataSource = Me.sqlResources
        Me.Table1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox23, Me.TextBox3})
        Me.Table1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.399999618530273R), Telerik.Reporting.Drawing.Unit.Cm(0.33270859718322754R))
        Me.Table1.Name = "Table1"
        TableGroup4.Groupings.Add(New Telerik.Reporting.Grouping(Nothing))
        TableGroup4.Name = "detailTableGroup"
        Me.Table1.RowGroups.Add(TableGroup4)
        Me.Table1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.0999999046325684R), Telerik.Reporting.Drawing.Unit.Cm(1.1641668081283569R))
        '
        'TextBox23
        '
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.0999999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60854184627532959R))
        Me.TextBox23.Value = "=Fields.Name"
        '
        'sqlResources
        '
        Me.sqlResources.ConnectionString = "My.Reports.My.MySettings.ResourceBookingCalendar"
        Me.sqlResources.Name = "sqlResources"
        Me.sqlResources.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@ClassID", System.Data.DbType.[String], "=Parameters.ClassID.Value")})
        Me.sqlResources.SelectCommand = resources.GetString("sqlResources.SelectCommand")
        '
        'TextBox24
        '
        Me.TextBox24.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.30000025033950806R), Telerik.Reporting.Drawing.Unit.Cm(0.33270859718322754R))
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0R), Telerik.Reporting.Drawing.Unit.Cm(0.69999963045120239R))
        Me.TextBox24.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TextBox24.Style.Color = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.TextBox24.Style.Font.Bold = True
        Me.TextBox24.Value = "Date"
        '
        'TextBox25
        '
        Me.TextBox25.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.3999998569488525R), Telerik.Reporting.Drawing.Unit.Cm(0.33270859718322754R))
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.4000000953674316R), Telerik.Reporting.Drawing.Unit.Cm(0.69999963045120239R))
        Me.TextBox25.Value = "=Fields.Start + ' ' + Fields.End "
        '
        'TextBox10
        '
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox10.StyleName = "Office.TableBody"
        Me.TextBox10.Value = ""
        '
        'TextBox4
        '
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5399999618530273R), Telerik.Reporting.Drawing.Unit.Cm(1.2699999809265137R))
        '
        'Cost
        '
        Me.Cost.ConnectionString = "My.Reports.My.MySettings.ResourceBookingCalendar"
        Me.Cost.Name = "Cost"
        Me.Cost.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@CourseID", System.Data.DbType.Int32, "=Parameters.ClassID.Value")})
        Me.Cost.SelectCommand = "dbo.sp_CalculateCost"
        Me.Cost.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'Table3
        '
        Me.Table3.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(2.0R)))
        Me.Table3.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.5R)))
        Me.Table3.Body.SetCellContent(0, 0, Me.TextBox27)
        TableGroup5.ReportItem = Me.TextBox26
        Me.Table3.ColumnGroups.Add(TableGroup5)
        Me.Table3.DataSource = Me.Cost
        Me.Table3.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox26, Me.TextBox27})
        Me.Table3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.39687499403953552R), Telerik.Reporting.Drawing.Unit.Cm(7.6469831466674805R))
        Me.Table3.Name = "Table3"
        TableGroup6.Groupings.Add(New Telerik.Reporting.Grouping(Nothing))
        TableGroup6.Name = "Detail"
        Me.Table3.RowGroups.Add(TableGroup6)
        Me.Table3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0R), Telerik.Reporting.Drawing.Unit.Cm(1.0R))
        Me.Table3.StyleName = "Office.TableNormal"
        '
        'TextBox26
        '
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox26.StyleName = "Office.TableHeader"
        Me.TextBox26.Value = "Cost"
        '
        'TextBox27
        '
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox27.StyleName = "Office.TableBody"
        Me.TextBox27.Value = "=Fields.[1]"
        '
        'BookingReport
        '
        Me.DataSource = Me.SqlDataSource1
        Group1.GroupFooter = Me.labelsGroupFooterSection
        Group1.GroupHeader = Me.labelsGroupHeaderSection
        Group1.Name = "labelsGroup"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeaderSection, Me.labelsGroupFooterSection, Me.reportHeader, Me.reportFooter, Me.detail})
        Me.Name = "BookingReport"
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273R), Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273R), Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273R), Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        ReportParameter1.Name = "ClassID"
        ReportParameter1.Text = "ClassID"
        ReportParameter1.Type = Telerik.Reporting.ReportParameterType.[Integer]
        ReportParameter1.Value = ""
        Me.ReportParameters.Add(ReportParameter1)
        Me.Style.BackgroundColor = System.Drawing.Color.White
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Title")})
        StyleRule1.Style.Color = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(74, Byte), Integer))
        StyleRule1.Style.Font.Name = "Georgia"
        StyleRule1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18.0R)
        StyleRule2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Caption")})
        StyleRule2.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(173, Byte), Integer))
        StyleRule2.Style.BorderColor.Default = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(212, Byte), Integer))
        StyleRule2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Dotted
        StyleRule2.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule2.Style.Color = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer))
        StyleRule2.Style.Font.Name = "Georgia"
        StyleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        StyleRule2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        StyleRule3.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Data")})
        StyleRule3.Style.Font.Name = "Georgia"
        StyleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        StyleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        StyleRule4.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("PageInfo")})
        StyleRule4.Style.Font.Name = "Georgia"
        StyleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        StyleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        StyleRule5.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.Table), "Office.TableNormal")})
        StyleRule5.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule5.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule5.Style.Color = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(77, Byte), Integer))
        StyleRule5.Style.Font.Name = "Calibri"
        StyleRule5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        DescendantSelector1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Office.TableHeader")})
        StyleRule6.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector1})
        StyleRule6.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(227, Byte), Integer))
        StyleRule6.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule6.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule6.Style.Color = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(77, Byte), Integer))
        StyleRule6.Style.Font.Name = "Calibri"
        StyleRule6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        StyleRule6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        DescendantSelector2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Office.TableBody")})
        StyleRule7.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector2})
        StyleRule7.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule7.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule7.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule7.Style.Font.Name = "Calibri"
        StyleRule7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1, StyleRule2, StyleRule3, StyleRule4, StyleRule5, StyleRule6, StyleRule7})
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(15.814167022705078R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents labelsGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents labelsGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents titleTextBox As Telerik.Reporting.TextBox
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents Resources As Telerik.Reporting.SqlDataSource
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents Table2 As Telerik.Reporting.Table
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox21 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox22 As Telerik.Reporting.TextBox
    Friend WithEvents Shape1 As Telerik.Reporting.Shape
    Friend WithEvents Shape2 As Telerik.Reporting.Shape
    Friend WithEvents Table1 As Telerik.Reporting.Table
    Friend WithEvents TextBox23 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents sqlResources As Telerik.Reporting.SqlDataSource
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox24 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox25 As Telerik.Reporting.TextBox
    Friend WithEvents Cost As Telerik.Reporting.SqlDataSource
    Friend WithEvents Table3 As Telerik.Reporting.Table
    Friend WithEvents TextBox27 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox26 As Telerik.Reporting.TextBox
End Class
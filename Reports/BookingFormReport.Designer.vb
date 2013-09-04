Partial Class BookingFormReport
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookingFormReport))
        Dim TableGroup1 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup2 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup3 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup4 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup5 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup6 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup7 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup8 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup9 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup10 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup11 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup12 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup13 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.labelsGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.labelsGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.reportNameTextBox = New Telerik.Reporting.TextBox()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.currentTimeTextBox = New Telerik.Reporting.TextBox()
        Me.pageInfoTextBox = New Telerik.Reporting.TextBox()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.titleTextBox = New Telerik.Reporting.TextBox()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.Table1 = New Telerik.Reporting.Table()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.Table2 = New Telerik.Reporting.Table()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        Me.TextBox22 = New Telerik.Reporting.TextBox()
        Me.TextBox23 = New Telerik.Reporting.TextBox()
        Me.TextBox24 = New Telerik.Reporting.TextBox()
        Me.TextBox25 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "My.Reports.My.MySettings.ResourceBookingCalendar"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@ClassID", System.Data.DbType.[String], "245")})
        Me.SqlDataSource1.SelectCommand = resources.GetString("SqlDataSource1.SelectCommand")
        '
        'labelsGroupHeaderSection
        '
        Me.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(2.7412497997283936R)
        Me.labelsGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox1, Me.TextBox2, Me.Table1})
        Me.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection"
        Me.labelsGroupHeaderSection.PrintOnEveryPage = True
        '
        'labelsGroupFooterSection
        '
        Me.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155R)
        Me.labelsGroupFooterSection.Name = "labelsGroupFooterSection"
        Me.labelsGroupFooterSection.Style.Visible = False
        '
        'pageHeader
        '
        Me.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567R)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.reportNameTextBox})
        Me.pageHeader.Name = "pageHeader"
        '
        'reportNameTextBox
        '
        Me.reportNameTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.reportNameTextBox.Name = "reportNameTextBox"
        Me.reportNameTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.708333015441895R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.reportNameTextBox.StyleName = "PageInfo"
        Me.reportNameTextBox.Value = "BookingFormReport"
        '
        'pageFooter
        '
        Me.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567R)
        Me.pageFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.currentTimeTextBox, Me.pageInfoTextBox})
        Me.pageFooter.Name = "pageFooter"
        '
        'currentTimeTextBox
        '
        Me.currentTimeTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.currentTimeTextBox.Name = "currentTimeTextBox"
        Me.currentTimeTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.8277082443237305R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.currentTimeTextBox.StyleName = "PageInfo"
        Me.currentTimeTextBox.Value = "=NOW()"
        '
        'pageInfoTextBox
        '
        Me.pageInfoTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.9335417747497559R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.pageInfoTextBox.Name = "pageInfoTextBox"
        Me.pageInfoTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.8277082443237305R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.pageInfoTextBox.StyleName = "PageInfo"
        Me.pageInfoTextBox.Value = "=PageNumber"
        '
        'reportHeader
        '
        Me.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(2.0529167652130127R)
        Me.reportHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.titleTextBox})
        Me.reportHeader.Name = "reportHeader"
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.814167022705078R), Telerik.Reporting.Drawing.Unit.Cm(2.0R))
        Me.titleTextBox.StyleName = "Title"
        Me.titleTextBox.Value = "BookingFormReport"
        '
        'reportFooter
        '
        Me.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(5.8792743682861328R)
        Me.reportFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Table2, Me.TextBox25})
        Me.reportFooter.Name = "reportFooter"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(0.70000004768371582R)
        Me.detail.Name = "detail"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.7000000476837158R), Telerik.Reporting.Drawing.Unit.Cm(0.44124969840049744R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox1.Value = "=Fields.Start.Date"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.40000000596046448R), Telerik.Reporting.Drawing.Unit.Cm(0.44124969840049744R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox2.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox2.Style.Font.Bold = True
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox2.Value = "Todays Date :"
        '
        'TextBox4
        '
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.9999992847442627R), Telerik.Reporting.Drawing.Unit.Cm(0.4999997615814209R))
        Me.TextBox4.Value = "=Fields.ClassID"
        '
        'Table1
        '
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(3.899998664855957R)))
        Me.Table1.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(1.0502365827560425R)))
        Me.Table1.Body.SetCellContent(0, 0, Me.TextBox11)
        TableGroup1.Name = "tableGroup"
        TableGroup1.ReportItem = Me.TextBox5
        Me.Table1.ColumnGroups.Add(TableGroup1)
        Me.Table1.DataSource = Me.SqlDataSource1
        Me.Table1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox5, Me.TextBox11})
        Me.Table1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.000000953674316R), Telerik.Reporting.Drawing.Unit.Cm(0.00010012308484874666R))
        Me.Table1.Name = "Table1"
        TableGroup2.Groupings.Add(New Telerik.Reporting.Grouping(Nothing))
        TableGroup2.Name = "detailTableGroup"
        Me.Table1.RowGroups.Add(TableGroup2)
        Me.Table1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.899998664855957R), Telerik.Reporting.Drawing.Unit.Cm(2.0733022689819336R))
        '
        'TextBox6
        '
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5399999618530273R), Telerik.Reporting.Drawing.Unit.Cm(1.2699999809265137R))
        '
        'TextBox5
        '
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.899998664855957R), Telerik.Reporting.Drawing.Unit.Cm(1.0230655670166016R))
        Me.TextBox5.Style.BackgroundColor = System.Drawing.Color.Gray
        Me.TextBox5.Style.Font.Bold = True
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox5.Value = "Booking Reference number"
        '
        'TextBox11
        '
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.899998664855957R), Telerik.Reporting.Drawing.Unit.Cm(1.050236701965332R))
        Me.TextBox11.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox11.Value = "=Fields.ClassID"
        '
        'Table2
        '
        Me.Table2.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(3.8629155158996582R)))
        Me.Table2.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(5.9266676902771R)))
        Me.Table2.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(5.476874828338623R)))
        Me.Table2.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(5.0691671371459961R)))
        Me.Table2.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.47625020146369934R)))
        Me.Table2.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.4972916841506958R)))
        Me.Table2.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.44437500834465027R)))
        Me.Table2.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(1.0000002384185791R)))
        Me.Table2.Body.SetCellContent(0, 0, Me.TextBox7)
        Me.Table2.Body.SetCellContent(0, 1, Me.TextBox9)
        Me.Table2.Body.SetCellContent(0, 2, Me.TextBox12)
        Me.Table2.Body.SetCellContent(0, 3, Me.TextBox14)
        Me.Table2.Body.SetCellContent(1, 0, Me.TextBox8)
        Me.Table2.Body.SetCellContent(1, 1, Me.TextBox13)
        Me.Table2.Body.SetCellContent(1, 2, Me.TextBox15)
        Me.Table2.Body.SetCellContent(1, 3, Me.TextBox16)
        Me.Table2.Body.SetCellContent(2, 0, Me.TextBox17)
        Me.Table2.Body.SetCellContent(2, 1, Me.TextBox18)
        Me.Table2.Body.SetCellContent(2, 2, Me.TextBox19)
        Me.Table2.Body.SetCellContent(2, 3, Me.TextBox20)
        Me.Table2.Body.SetCellContent(3, 0, Me.TextBox21)
        Me.Table2.Body.SetCellContent(3, 1, Me.TextBox22)
        Me.Table2.Body.SetCellContent(3, 2, Me.TextBox23)
        Me.Table2.Body.SetCellContent(3, 3, Me.TextBox24)
        TableGroup4.Name = "group1"
        TableGroup5.Name = "tableGroup2"
        TableGroup3.ChildGroups.Add(TableGroup4)
        TableGroup3.ChildGroups.Add(TableGroup5)
        TableGroup3.Name = "tableGroup1"
        TableGroup3.ReportItem = Me.TextBox3
        TableGroup7.Name = "group2"
        TableGroup8.Name = "group"
        TableGroup6.ChildGroups.Add(TableGroup7)
        TableGroup6.ChildGroups.Add(TableGroup8)
        TableGroup6.Name = "tableGroup3"
        TableGroup6.ReportItem = Me.TextBox10
        Me.Table2.ColumnGroups.Add(TableGroup3)
        Me.Table2.ColumnGroups.Add(TableGroup6)
        Me.Table2.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox3, Me.TextBox7, Me.TextBox9, Me.TextBox10, Me.TextBox12, Me.TextBox14, Me.TextBox8, Me.TextBox13, Me.TextBox15, Me.TextBox16, Me.TextBox17, Me.TextBox18, Me.TextBox19, Me.TextBox20, Me.TextBox21, Me.TextBox22, Me.TextBox23, Me.TextBox24})
        Me.Table2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.Table2.Name = "Table2"
        TableGroup10.Name = "group3"
        TableGroup11.Name = "group4"
        TableGroup12.Name = "group5"
        TableGroup13.Name = "group6"
        TableGroup9.ChildGroups.Add(TableGroup10)
        TableGroup9.ChildGroups.Add(TableGroup11)
        TableGroup9.ChildGroups.Add(TableGroup12)
        TableGroup9.ChildGroups.Add(TableGroup13)
        TableGroup9.Groupings.Add(New Telerik.Reporting.Grouping(Nothing))
        TableGroup9.Name = "detailTableGroup1"
        Me.Table2.RowGroups.Add(TableGroup9)
        Me.Table2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(20.335624694824219R), Telerik.Reporting.Drawing.Unit.Cm(3.6879174709320068R))
        '
        'TextBox3
        '
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(9.7895822525024414R), Telerik.Reporting.Drawing.Unit.Cm(1.2700005769729614R))
        Me.TextBox3.Style.Font.Bold = True
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox3.Style.Font.Underline = True
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox3.Value = "Training Room"
        '
        'TextBox7
        '
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.8629164695739746R), Telerik.Reporting.Drawing.Unit.Cm(0.47625020146369934R))
        Me.TextBox7.Value = "Full Day"
        '
        'TextBox9
        '
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.9266672134399414R), Telerik.Reporting.Drawing.Unit.Cm(0.47625020146369934R))
        Me.TextBox9.Value = "£110.00"
        '
        'TextBox10
        '
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(10.546042442321777R), Telerik.Reporting.Drawing.Unit.Cm(1.2700005769729614R))
        Me.TextBox10.Style.Font.Bold = True
        Me.TextBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox10.Style.Font.Underline = True
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox10.Value = "Board Room" & Global.Microsoft.VisualBasic.ChrW(9)
        '
        'TextBox12
        '
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.4768738746643066R), Telerik.Reporting.Drawing.Unit.Cm(0.47625020146369934R))
        Me.TextBox12.Value = "Full Day" & Global.Microsoft.VisualBasic.ChrW(9)
        '
        'TextBox14
        '
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.0691671371459961R), Telerik.Reporting.Drawing.Unit.Cm(0.47625020146369934R))
        Me.TextBox14.StyleName = ""
        Me.TextBox14.Value = "£100.00"
        '
        'TextBox8
        '
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.8629164695739746R), Telerik.Reporting.Drawing.Unit.Cm(0.4972916841506958R))
        Me.TextBox8.StyleName = ""
        Me.TextBox8.Value = "Half Day" & Global.Microsoft.VisualBasic.ChrW(9)
        '
        'TextBox13
        '
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.9266672134399414R), Telerik.Reporting.Drawing.Unit.Cm(0.4972916841506958R))
        Me.TextBox13.StyleName = ""
        Me.TextBox13.Value = "£70.00"
        '
        'TextBox15
        '
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.4768738746643066R), Telerik.Reporting.Drawing.Unit.Cm(0.4972916841506958R))
        Me.TextBox15.StyleName = ""
        Me.TextBox15.Value = "Half Day"
        '
        'TextBox16
        '
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.0691671371459961R), Telerik.Reporting.Drawing.Unit.Cm(0.4972916841506958R))
        Me.TextBox16.StyleName = ""
        Me.TextBox16.Value = "£60.00"
        '
        'TextBox17
        '
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.8629164695739746R), Telerik.Reporting.Drawing.Unit.Cm(0.44437500834465027R))
        Me.TextBox17.StyleName = ""
        Me.TextBox17.Value = "Evening Rate (Per HR)" & Global.Microsoft.VisualBasic.ChrW(9)
        '
        'TextBox18
        '
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.9266672134399414R), Telerik.Reporting.Drawing.Unit.Cm(0.44437500834465027R))
        Me.TextBox18.StyleName = ""
        Me.TextBox18.Value = "£20.00"
        '
        'TextBox19
        '
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.4768738746643066R), Telerik.Reporting.Drawing.Unit.Cm(0.44437500834465027R))
        Me.TextBox19.StyleName = ""
        Me.TextBox19.Value = "Evening Rate"
        '
        'TextBox20
        '
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.0691671371459961R), Telerik.Reporting.Drawing.Unit.Cm(0.44437500834465027R))
        Me.TextBox20.StyleName = ""
        Me.TextBox20.Value = "£20.00"
        '
        'TextBox21
        '
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.8629164695739746R), Telerik.Reporting.Drawing.Unit.Cm(1.0000002384185791R))
        Me.TextBox21.StyleName = ""
        Me.TextBox21.Value = "Tea/Coffee"
        '
        'TextBox22
        '
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.9266672134399414R), Telerik.Reporting.Drawing.Unit.Cm(1.0000002384185791R))
        Me.TextBox22.StyleName = ""
        Me.TextBox22.Value = "£1.00" & Global.Microsoft.VisualBasic.ChrW(9)
        '
        'TextBox23
        '
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.4768738746643066R), Telerik.Reporting.Drawing.Unit.Cm(1.0000002384185791R))
        Me.TextBox23.StyleName = ""
        Me.TextBox23.Value = "Tea/Coffee"
        '
        'TextBox24
        '
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.0691671371459961R), Telerik.Reporting.Drawing.Unit.Cm(1.0000002384185791R))
        Me.TextBox24.StyleName = ""
        Me.TextBox24.Value = "£1.00"
        '
        'TextBox25
        '
        Me.TextBox25.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R), Telerik.Reporting.Drawing.Unit.Cm(4.2856249809265137R))
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(20.282608032226562R), Telerik.Reporting.Drawing.Unit.Cm(0.9999995231628418R))
        Me.TextBox25.Value = "CANCELLATION" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Notice of three"
        '
        'BookingFormReport
        '
        Me.DataSource = Me.SqlDataSource1
        Group1.GroupFooter = Me.labelsGroupFooterSection
        Group1.GroupHeader = Me.labelsGroupHeaderSection
        Group1.Name = "labelsGroup"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeaderSection, Me.labelsGroupFooterSection, Me.pageHeader, Me.pageFooter, Me.reportHeader, Me.reportFooter, Me.detail})
        Me.Name = "BookingFormReport"
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273R), Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273R), Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273R), Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
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
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1, StyleRule2, StyleRule3, StyleRule4})
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(20.335624694824219R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents labelsGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents Table1 As Telerik.Reporting.Table
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents reportNameTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents currentTimeTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pageInfoTextBox As Telerik.Reporting.TextBox
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents titleTextBox As Telerik.Reporting.TextBox
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents Table2 As Telerik.Reporting.Table
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox21 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox22 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox23 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox24 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox25 As Telerik.Reporting.TextBox
End Class
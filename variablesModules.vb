Module variablesModules

    ' declaring variables to hold applicant info
    Public applicant, Surname, OtherName, VillageTown, addressOfSupply, LGA, State, TelNo, AlternateNo, TypeOfPremises, NoOfFloors, NoOfFlats As String
    Public UseOfPremises, NameOnTheBill, AccountNumber, OldMeterNumber, TariffClass, ExistingConnectionDetails, CurrentBillinngInfo As String
    Public MeterType, TypeOfConnection, Area As String
    Public totalWatts As Integer


    'declare variables to hold office data
    Public OffAccountNumber, OffMeterNo, OffMeterMake, OffLastBillAmt, OffTotalOuts As String
    Public OffTotalInstalledLoad, OffEstimateLoadApplied, OffRequestedVoltageType, OffTypeOfMeter As String
    Public OffPoleAvailable, OffPoleCondition, OffPoleType, OffServiceLine, OffLineWireCondition As String


    'declare database and entity variables

    Public CustomerData1 As New CustomerData

    'declare rate variable
    Public rate As Integer

    'declare card variable
    Public CardNo As String

End Module

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SteamTablesDemo.SteamTablesServices {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://INEEL.org.mx/", ConfigurationName="SteamTablesServices.INEELSteamTablesSoap")]
    public interface INEELSteamTablesSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://INEEL.org.mx/MKSIAPWS95T", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SteamTablesDemo.SteamTablesServices.WtrProps MKSIAPWS95T(SteamTablesDemo.SteamTablesServices.WtrSepBoundary SepBoundary, double Temp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://INEEL.org.mx/MKSIAPWS95T", ReplyAction="*")]
        System.Threading.Tasks.Task<SteamTablesDemo.SteamTablesServices.WtrProps> MKSIAPWS95TAsync(SteamTablesDemo.SteamTablesServices.WtrSepBoundary SepBoundary, double Temp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://INEEL.org.mx/MKSIAPWS95P", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SteamTablesDemo.SteamTablesServices.WtrProps MKSIAPWS95P(SteamTablesDemo.SteamTablesServices.WtrSepBoundary SepBoundary, double Press);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://INEEL.org.mx/MKSIAPWS95P", ReplyAction="*")]
        System.Threading.Tasks.Task<SteamTablesDemo.SteamTablesServices.WtrProps> MKSIAPWS95PAsync(SteamTablesDemo.SteamTablesServices.WtrSepBoundary SepBoundary, double Press);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://INEEL.org.mx/MKSIAPWS95TP", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SteamTablesDemo.SteamTablesServices.WtrProps MKSIAPWS95TP(double Temp, double Press);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://INEEL.org.mx/MKSIAPWS95TP", ReplyAction="*")]
        System.Threading.Tasks.Task<SteamTablesDemo.SteamTablesServices.WtrProps> MKSIAPWS95TPAsync(double Temp, double Press);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://INEEL.org.mx/MKSIAPWSIF97T", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SteamTablesDemo.SteamTablesServices.WtrProps MKSIAPWSIF97T(SteamTablesDemo.SteamTablesServices.WtrSepBoundary SepBoundary, double Temp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://INEEL.org.mx/MKSIAPWSIF97T", ReplyAction="*")]
        System.Threading.Tasks.Task<SteamTablesDemo.SteamTablesServices.WtrProps> MKSIAPWSIF97TAsync(SteamTablesDemo.SteamTablesServices.WtrSepBoundary SepBoundary, double Temp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://INEEL.org.mx/MKSIAPWSIF97P", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SteamTablesDemo.SteamTablesServices.WtrProps MKSIAPWSIF97P(SteamTablesDemo.SteamTablesServices.WtrSepBoundary SepBoundary, double Press);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://INEEL.org.mx/MKSIAPWSIF97P", ReplyAction="*")]
        System.Threading.Tasks.Task<SteamTablesDemo.SteamTablesServices.WtrProps> MKSIAPWSIF97PAsync(SteamTablesDemo.SteamTablesServices.WtrSepBoundary SepBoundary, double Press);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://INEEL.org.mx/MKSIAPWSIF97TP", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SteamTablesDemo.SteamTablesServices.WtrProps MKSIAPWSIF97TP(double Temp, double Press);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://INEEL.org.mx/MKSIAPWSIF97TP", ReplyAction="*")]
        System.Threading.Tasks.Task<SteamTablesDemo.SteamTablesServices.WtrProps> MKSIAPWSIF97TPAsync(double Temp, double Press);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://INEEL.org.mx/IAPWS95T", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SteamTablesDemo.SteamTablesServices.WtrProps IAPWS95T(SteamTablesDemo.SteamTablesServices.WtrSepBoundary SepBoundary, double Temp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://INEEL.org.mx/IAPWS95T", ReplyAction="*")]
        System.Threading.Tasks.Task<SteamTablesDemo.SteamTablesServices.WtrProps> IAPWS95TAsync(SteamTablesDemo.SteamTablesServices.WtrSepBoundary SepBoundary, double Temp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://INEEL.org.mx/IAPWS95P", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SteamTablesDemo.SteamTablesServices.WtrProps IAPWS95P(SteamTablesDemo.SteamTablesServices.WtrSepBoundary SepBoundary, double Press);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://INEEL.org.mx/IAPWS95P", ReplyAction="*")]
        System.Threading.Tasks.Task<SteamTablesDemo.SteamTablesServices.WtrProps> IAPWS95PAsync(SteamTablesDemo.SteamTablesServices.WtrSepBoundary SepBoundary, double Press);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://INEEL.org.mx/IAPWS95TP", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SteamTablesDemo.SteamTablesServices.WtrProps IAPWS95TP(double Temp, double Press);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://INEEL.org.mx/IAPWS95TP", ReplyAction="*")]
        System.Threading.Tasks.Task<SteamTablesDemo.SteamTablesServices.WtrProps> IAPWS95TPAsync(double Temp, double Press);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://INEEL.org.mx/IAPWSIF97T", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SteamTablesDemo.SteamTablesServices.WtrProps IAPWSIF97T(SteamTablesDemo.SteamTablesServices.WtrSepBoundary SepBoundary, double Temp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://INEEL.org.mx/IAPWSIF97T", ReplyAction="*")]
        System.Threading.Tasks.Task<SteamTablesDemo.SteamTablesServices.WtrProps> IAPWSIF97TAsync(SteamTablesDemo.SteamTablesServices.WtrSepBoundary SepBoundary, double Temp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://INEEL.org.mx/IAPWSIF97P", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SteamTablesDemo.SteamTablesServices.WtrProps IAPWSIF97P(SteamTablesDemo.SteamTablesServices.WtrSepBoundary SepBoundary, double Press);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://INEEL.org.mx/IAPWSIF97P", ReplyAction="*")]
        System.Threading.Tasks.Task<SteamTablesDemo.SteamTablesServices.WtrProps> IAPWSIF97PAsync(SteamTablesDemo.SteamTablesServices.WtrSepBoundary SepBoundary, double Press);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://INEEL.org.mx/IAPWSIF97TP", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SteamTablesDemo.SteamTablesServices.WtrProps IAPWSIF97TP(double Temp, double Press);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://INEEL.org.mx/IAPWSIF97TP", ReplyAction="*")]
        System.Threading.Tasks.Task<SteamTablesDemo.SteamTablesServices.WtrProps> IAPWSIF97TPAsync(double Temp, double Press);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://INEEL.org.mx/CalcVesselWtrHeating", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SteamTablesDemo.SteamTablesServices.WtrHeating CalcVesselWtrHeating(double TMass, double TVolume, double Temperature, double TLiqVapFull);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://INEEL.org.mx/CalcVesselWtrHeating", ReplyAction="*")]
        System.Threading.Tasks.Task<SteamTablesDemo.SteamTablesServices.WtrHeating> CalcVesselWtrHeatingAsync(double TMass, double TVolume, double Temperature, double TLiqVapFull);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://INEEL.org.mx/TempLiqVapFull", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SteamTablesDemo.SteamTablesServices.TLiqVapType TempLiqVapFull(double TMass, double TVolume);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://INEEL.org.mx/TempLiqVapFull", ReplyAction="*")]
        System.Threading.Tasks.Task<SteamTablesDemo.SteamTablesServices.TLiqVapType> TempLiqVapFullAsync(double TMass, double TVolume);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://INEEL.org.mx/CalcWaterLevel", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SteamTablesDemo.SteamTablesServices.WaterLevel CalcWaterLevel(double TMass, double TVolume, double Temp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://INEEL.org.mx/CalcWaterLevel", ReplyAction="*")]
        System.Threading.Tasks.Task<SteamTablesDemo.SteamTablesServices.WaterLevel> CalcWaterLevelAsync(double TMass, double TVolume, double Temp);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://INEEL.org.mx/")]
    public enum WtrSepBoundary {
        
        /// <remarks/>
        Undefined,
        
        /// <remarks/>
        Sublimation,
        
        /// <remarks/>
        Saturation,
        
        /// <remarks/>
        CriticalIsochor,
        
        /// <remarks/>
        IceIMelting,
        
        /// <remarks/>
        IceIII_VIIMelting,
        
        /// <remarks/>
        MinimumVolume,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://INEEL.org.mx/")]
    public partial class WtrProps : object, System.ComponentModel.INotifyPropertyChanged {
        
        private double tempField;
        
        private double pressField;
        
        private WtrState stateField;
        
        private PhaseProps liquidField;
        
        private PhaseProps vaporField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public double Temp {
            get {
                return this.tempField;
            }
            set {
                this.tempField = value;
                this.RaisePropertyChanged("Temp");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public double Press {
            get {
                return this.pressField;
            }
            set {
                this.pressField = value;
                this.RaisePropertyChanged("Press");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public WtrState State {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
                this.RaisePropertyChanged("State");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public PhaseProps Liquid {
            get {
                return this.liquidField;
            }
            set {
                this.liquidField = value;
                this.RaisePropertyChanged("Liquid");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public PhaseProps Vapor {
            get {
                return this.vaporField;
            }
            set {
                this.vaporField = value;
                this.RaisePropertyChanged("Vapor");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://INEEL.org.mx/")]
    public enum WtrState {
        
        /// <remarks/>
        Unknown,
        
        /// <remarks/>
        TriplePoint,
        
        /// <remarks/>
        CriticalPoint,
        
        /// <remarks/>
        MinimumVolumeSaturationPoint,
        
        /// <remarks/>
        IceI_Liquid_Liquid1Point,
        
        /// <remarks/>
        IceI_IceIIIPoint,
        
        /// <remarks/>
        Sublimation,
        
        /// <remarks/>
        SaturationLiquid_Vapor,
        
        /// <remarks/>
        SaturationLiquid1_Vapor,
        
        /// <remarks/>
        CriticalIsochor,
        
        /// <remarks/>
        IceI_LiquidCurve,
        
        /// <remarks/>
        IceI_Liquid1Curve,
        
        /// <remarks/>
        IceIII_IceVIIMeltingCurve,
        
        /// <remarks/>
        MinimumVolumeCurve,
        
        /// <remarks/>
        SuperheatedSteam,
        
        /// <remarks/>
        CompressedLiquid,
        
        /// <remarks/>
        CompressedLiquid1,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://INEEL.org.mx/")]
    public partial class PhaseProps : object, System.ComponentModel.INotifyPropertyChanged {
        
        private double volumeField;
        
        private double densityField;
        
        private double zoField;
        
        private double uField;
        
        private double hField;
        
        private double gField;
        
        private double aField;
        
        private double sField;
        
        private double cpField;
        
        private double cvField;
        
        private double cTEField;
        
        private double zisoField;
        
        private double velSField;
        
        private double dPdTField;
        
        private double dTdVField;
        
        private double dVdPField;
        
        private double jTCField;
        
        private double iJTCField;
        
        private double visField;
        
        private double thrmCondField;
        
        private double surfTenField;
        
        private double prdNumField;
        
        private double dielConsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public double Volume {
            get {
                return this.volumeField;
            }
            set {
                this.volumeField = value;
                this.RaisePropertyChanged("Volume");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public double Density {
            get {
                return this.densityField;
            }
            set {
                this.densityField = value;
                this.RaisePropertyChanged("Density");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public double Zo {
            get {
                return this.zoField;
            }
            set {
                this.zoField = value;
                this.RaisePropertyChanged("Zo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public double U {
            get {
                return this.uField;
            }
            set {
                this.uField = value;
                this.RaisePropertyChanged("U");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public double H {
            get {
                return this.hField;
            }
            set {
                this.hField = value;
                this.RaisePropertyChanged("H");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public double G {
            get {
                return this.gField;
            }
            set {
                this.gField = value;
                this.RaisePropertyChanged("G");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public double A {
            get {
                return this.aField;
            }
            set {
                this.aField = value;
                this.RaisePropertyChanged("A");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public double S {
            get {
                return this.sField;
            }
            set {
                this.sField = value;
                this.RaisePropertyChanged("S");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public double Cp {
            get {
                return this.cpField;
            }
            set {
                this.cpField = value;
                this.RaisePropertyChanged("Cp");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public double Cv {
            get {
                return this.cvField;
            }
            set {
                this.cvField = value;
                this.RaisePropertyChanged("Cv");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public double CTE {
            get {
                return this.cTEField;
            }
            set {
                this.cTEField = value;
                this.RaisePropertyChanged("CTE");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public double Ziso {
            get {
                return this.zisoField;
            }
            set {
                this.zisoField = value;
                this.RaisePropertyChanged("Ziso");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public double VelS {
            get {
                return this.velSField;
            }
            set {
                this.velSField = value;
                this.RaisePropertyChanged("VelS");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public double dPdT {
            get {
                return this.dPdTField;
            }
            set {
                this.dPdTField = value;
                this.RaisePropertyChanged("dPdT");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public double dTdV {
            get {
                return this.dTdVField;
            }
            set {
                this.dTdVField = value;
                this.RaisePropertyChanged("dTdV");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public double dVdP {
            get {
                return this.dVdPField;
            }
            set {
                this.dVdPField = value;
                this.RaisePropertyChanged("dVdP");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=16)]
        public double JTC {
            get {
                return this.jTCField;
            }
            set {
                this.jTCField = value;
                this.RaisePropertyChanged("JTC");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=17)]
        public double IJTC {
            get {
                return this.iJTCField;
            }
            set {
                this.iJTCField = value;
                this.RaisePropertyChanged("IJTC");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=18)]
        public double Vis {
            get {
                return this.visField;
            }
            set {
                this.visField = value;
                this.RaisePropertyChanged("Vis");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=19)]
        public double ThrmCond {
            get {
                return this.thrmCondField;
            }
            set {
                this.thrmCondField = value;
                this.RaisePropertyChanged("ThrmCond");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=20)]
        public double SurfTen {
            get {
                return this.surfTenField;
            }
            set {
                this.surfTenField = value;
                this.RaisePropertyChanged("SurfTen");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=21)]
        public double PrdNum {
            get {
                return this.prdNumField;
            }
            set {
                this.prdNumField = value;
                this.RaisePropertyChanged("PrdNum");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=22)]
        public double DielCons {
            get {
                return this.dielConsField;
            }
            set {
                this.dielConsField = value;
                this.RaisePropertyChanged("DielCons");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://INEEL.org.mx/")]
    public partial class WaterLevel : object, System.ComponentModel.INotifyPropertyChanged {
        
        private double levelField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public double Level {
            get {
                return this.levelField;
            }
            set {
                this.levelField = value;
                this.RaisePropertyChanged("Level");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://INEEL.org.mx/")]
    public partial class TLiqVapType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private double tempField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public double Temp {
            get {
                return this.tempField;
            }
            set {
                this.tempField = value;
                this.RaisePropertyChanged("Temp");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://INEEL.org.mx/")]
    public partial class WtrHeating : object, System.ComponentModel.INotifyPropertyChanged {
        
        private double volumeField;
        
        private double totalMassField;
        
        private double temperatureField;
        
        private double pressureField;
        
        private double liquidMassField;
        
        private double vaporMassField;
        
        private double waterLevelField;
        
        private double tLiqVapFullField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public double Volume {
            get {
                return this.volumeField;
            }
            set {
                this.volumeField = value;
                this.RaisePropertyChanged("Volume");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public double TotalMass {
            get {
                return this.totalMassField;
            }
            set {
                this.totalMassField = value;
                this.RaisePropertyChanged("TotalMass");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public double Temperature {
            get {
                return this.temperatureField;
            }
            set {
                this.temperatureField = value;
                this.RaisePropertyChanged("Temperature");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public double Pressure {
            get {
                return this.pressureField;
            }
            set {
                this.pressureField = value;
                this.RaisePropertyChanged("Pressure");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public double LiquidMass {
            get {
                return this.liquidMassField;
            }
            set {
                this.liquidMassField = value;
                this.RaisePropertyChanged("LiquidMass");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public double VaporMass {
            get {
                return this.vaporMassField;
            }
            set {
                this.vaporMassField = value;
                this.RaisePropertyChanged("VaporMass");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public double WaterLevel {
            get {
                return this.waterLevelField;
            }
            set {
                this.waterLevelField = value;
                this.RaisePropertyChanged("WaterLevel");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public double TLiqVapFull {
            get {
                return this.tLiqVapFullField;
            }
            set {
                this.tLiqVapFullField = value;
                this.RaisePropertyChanged("TLiqVapFull");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INEELSteamTablesSoapChannel : SteamTablesDemo.SteamTablesServices.INEELSteamTablesSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NEELSteamTablesSoapClient : System.ServiceModel.ClientBase<SteamTablesDemo.SteamTablesServices.INEELSteamTablesSoap>, SteamTablesDemo.SteamTablesServices.INEELSteamTablesSoap {
        
        public NEELSteamTablesSoapClient() {
        }
        
        public NEELSteamTablesSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NEELSteamTablesSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NEELSteamTablesSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NEELSteamTablesSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SteamTablesDemo.SteamTablesServices.WtrProps MKSIAPWS95T(SteamTablesDemo.SteamTablesServices.WtrSepBoundary SepBoundary, double Temp) {
            return base.Channel.MKSIAPWS95T(SepBoundary, Temp);
        }
        
        public System.Threading.Tasks.Task<SteamTablesDemo.SteamTablesServices.WtrProps> MKSIAPWS95TAsync(SteamTablesDemo.SteamTablesServices.WtrSepBoundary SepBoundary, double Temp) {
            return base.Channel.MKSIAPWS95TAsync(SepBoundary, Temp);
        }
        
        public SteamTablesDemo.SteamTablesServices.WtrProps MKSIAPWS95P(SteamTablesDemo.SteamTablesServices.WtrSepBoundary SepBoundary, double Press) {
            return base.Channel.MKSIAPWS95P(SepBoundary, Press);
        }
        
        public System.Threading.Tasks.Task<SteamTablesDemo.SteamTablesServices.WtrProps> MKSIAPWS95PAsync(SteamTablesDemo.SteamTablesServices.WtrSepBoundary SepBoundary, double Press) {
            return base.Channel.MKSIAPWS95PAsync(SepBoundary, Press);
        }
        
        public SteamTablesDemo.SteamTablesServices.WtrProps MKSIAPWS95TP(double Temp, double Press) {
            return base.Channel.MKSIAPWS95TP(Temp, Press);
        }
        
        public System.Threading.Tasks.Task<SteamTablesDemo.SteamTablesServices.WtrProps> MKSIAPWS95TPAsync(double Temp, double Press) {
            return base.Channel.MKSIAPWS95TPAsync(Temp, Press);
        }
        
        public SteamTablesDemo.SteamTablesServices.WtrProps MKSIAPWSIF97T(SteamTablesDemo.SteamTablesServices.WtrSepBoundary SepBoundary, double Temp) {
            return base.Channel.MKSIAPWSIF97T(SepBoundary, Temp);
        }
        
        public System.Threading.Tasks.Task<SteamTablesDemo.SteamTablesServices.WtrProps> MKSIAPWSIF97TAsync(SteamTablesDemo.SteamTablesServices.WtrSepBoundary SepBoundary, double Temp) {
            return base.Channel.MKSIAPWSIF97TAsync(SepBoundary, Temp);
        }
        
        public SteamTablesDemo.SteamTablesServices.WtrProps MKSIAPWSIF97P(SteamTablesDemo.SteamTablesServices.WtrSepBoundary SepBoundary, double Press) {
            return base.Channel.MKSIAPWSIF97P(SepBoundary, Press);
        }
        
        public System.Threading.Tasks.Task<SteamTablesDemo.SteamTablesServices.WtrProps> MKSIAPWSIF97PAsync(SteamTablesDemo.SteamTablesServices.WtrSepBoundary SepBoundary, double Press) {
            return base.Channel.MKSIAPWSIF97PAsync(SepBoundary, Press);
        }
        
        public SteamTablesDemo.SteamTablesServices.WtrProps MKSIAPWSIF97TP(double Temp, double Press) {
            return base.Channel.MKSIAPWSIF97TP(Temp, Press);
        }
        
        public System.Threading.Tasks.Task<SteamTablesDemo.SteamTablesServices.WtrProps> MKSIAPWSIF97TPAsync(double Temp, double Press) {
            return base.Channel.MKSIAPWSIF97TPAsync(Temp, Press);
        }
        
        public SteamTablesDemo.SteamTablesServices.WtrProps IAPWS95T(SteamTablesDemo.SteamTablesServices.WtrSepBoundary SepBoundary, double Temp) {
            return base.Channel.IAPWS95T(SepBoundary, Temp);
        }
        
        public System.Threading.Tasks.Task<SteamTablesDemo.SteamTablesServices.WtrProps> IAPWS95TAsync(SteamTablesDemo.SteamTablesServices.WtrSepBoundary SepBoundary, double Temp) {
            return base.Channel.IAPWS95TAsync(SepBoundary, Temp);
        }
        
        public SteamTablesDemo.SteamTablesServices.WtrProps IAPWS95P(SteamTablesDemo.SteamTablesServices.WtrSepBoundary SepBoundary, double Press) {
            return base.Channel.IAPWS95P(SepBoundary, Press);
        }
        
        public System.Threading.Tasks.Task<SteamTablesDemo.SteamTablesServices.WtrProps> IAPWS95PAsync(SteamTablesDemo.SteamTablesServices.WtrSepBoundary SepBoundary, double Press) {
            return base.Channel.IAPWS95PAsync(SepBoundary, Press);
        }
        
        public SteamTablesDemo.SteamTablesServices.WtrProps IAPWS95TP(double Temp, double Press) {
            return base.Channel.IAPWS95TP(Temp, Press);
        }
        
        public System.Threading.Tasks.Task<SteamTablesDemo.SteamTablesServices.WtrProps> IAPWS95TPAsync(double Temp, double Press) {
            return base.Channel.IAPWS95TPAsync(Temp, Press);
        }
        
        public SteamTablesDemo.SteamTablesServices.WtrProps IAPWSIF97T(SteamTablesDemo.SteamTablesServices.WtrSepBoundary SepBoundary, double Temp) {
            return base.Channel.IAPWSIF97T(SepBoundary, Temp);
        }
        
        public System.Threading.Tasks.Task<SteamTablesDemo.SteamTablesServices.WtrProps> IAPWSIF97TAsync(SteamTablesDemo.SteamTablesServices.WtrSepBoundary SepBoundary, double Temp) {
            return base.Channel.IAPWSIF97TAsync(SepBoundary, Temp);
        }
        
        public SteamTablesDemo.SteamTablesServices.WtrProps IAPWSIF97P(SteamTablesDemo.SteamTablesServices.WtrSepBoundary SepBoundary, double Press) {
            return base.Channel.IAPWSIF97P(SepBoundary, Press);
        }
        
        public System.Threading.Tasks.Task<SteamTablesDemo.SteamTablesServices.WtrProps> IAPWSIF97PAsync(SteamTablesDemo.SteamTablesServices.WtrSepBoundary SepBoundary, double Press) {
            return base.Channel.IAPWSIF97PAsync(SepBoundary, Press);
        }
        
        public SteamTablesDemo.SteamTablesServices.WtrProps IAPWSIF97TP(double Temp, double Press) {
            return base.Channel.IAPWSIF97TP(Temp, Press);
        }
        
        public System.Threading.Tasks.Task<SteamTablesDemo.SteamTablesServices.WtrProps> IAPWSIF97TPAsync(double Temp, double Press) {
            return base.Channel.IAPWSIF97TPAsync(Temp, Press);
        }
        
        public SteamTablesDemo.SteamTablesServices.WtrHeating CalcVesselWtrHeating(double TMass, double TVolume, double Temperature, double TLiqVapFull) {
            return base.Channel.CalcVesselWtrHeating(TMass, TVolume, Temperature, TLiqVapFull);
        }
        
        public System.Threading.Tasks.Task<SteamTablesDemo.SteamTablesServices.WtrHeating> CalcVesselWtrHeatingAsync(double TMass, double TVolume, double Temperature, double TLiqVapFull) {
            return base.Channel.CalcVesselWtrHeatingAsync(TMass, TVolume, Temperature, TLiqVapFull);
        }
        
        public SteamTablesDemo.SteamTablesServices.TLiqVapType TempLiqVapFull(double TMass, double TVolume) {
            return base.Channel.TempLiqVapFull(TMass, TVolume);
        }
        
        public System.Threading.Tasks.Task<SteamTablesDemo.SteamTablesServices.TLiqVapType> TempLiqVapFullAsync(double TMass, double TVolume) {
            return base.Channel.TempLiqVapFullAsync(TMass, TVolume);
        }
        
        public SteamTablesDemo.SteamTablesServices.WaterLevel CalcWaterLevel(double TMass, double TVolume, double Temp) {
            return base.Channel.CalcWaterLevel(TMass, TVolume, Temp);
        }
        
        public System.Threading.Tasks.Task<SteamTablesDemo.SteamTablesServices.WaterLevel> CalcWaterLevelAsync(double TMass, double TVolume, double Temp) {
            return base.Channel.CalcWaterLevelAsync(TMass, TVolume, Temp);
        }
    }
}

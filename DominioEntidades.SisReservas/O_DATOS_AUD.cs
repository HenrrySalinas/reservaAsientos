//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios en este archivo pueden ocasionar un comportamiento incorrecto y se perderán si
//     el código se vuelve a generar.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;

namespace DominioEntidades.SisReservas
{
    
    public partial class O_DATOS_AUD : INotifyComplexPropertyChanging, INotifyPropertyChanged
    {
        #region Propiedades primitivas
    
        [DataMember]
        public Nullable<decimal> APP_ID_USUARIO
        {
            get { return _aPP_ID_USUARIO; }
            set
            {
                if (_aPP_ID_USUARIO != value)
                {
                    OnComplexPropertyChanging();
                    _aPP_ID_USUARIO = value;
                    OnPropertyChanged("APP_ID_USUARIO");
                }
            }
        }
        private Nullable<decimal> _aPP_ID_USUARIO;
    
        [DataMember]
        public Nullable<decimal> AUD_ESTADO
        {
            get { return _aUD_ESTADO; }
            set
            {
                if (_aUD_ESTADO != value)
                {
                    OnComplexPropertyChanging();
                    _aUD_ESTADO = value;
                    OnPropertyChanged("AUD_ESTADO");
                }
            }
        }
        private Nullable<decimal> _aUD_ESTADO;
    
        [DataMember]
        public Nullable<System.DateTime> FECHA_REGISTRO
        {
            get { return _fECHA_REGISTRO; }
            set
            {
                if (_fECHA_REGISTRO != value)
                {
                    OnComplexPropertyChanging();
                    _fECHA_REGISTRO = value;
                    OnPropertyChanged("FECHA_REGISTRO");
                }
            }
        }
        private Nullable<System.DateTime> _fECHA_REGISTRO;

        #endregion

        #region ChangeTracking
    
        private void OnComplexPropertyChanging()
        {
            if (_complexPropertyChanging != null)
            {
                _complexPropertyChanging(this, new EventArgs());
            }
        }
    
        event EventHandler INotifyComplexPropertyChanging.ComplexPropertyChanging { add { _complexPropertyChanging += value; } remove { _complexPropertyChanging -= value; } }
        private event EventHandler _complexPropertyChanging;
    
        private void OnPropertyChanged(String propertyName)
        {
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged { add { _propertyChanged += value; } remove { _propertyChanged -= value; } }
        private event PropertyChangedEventHandler _propertyChanged;
    
        public static void RecordComplexOriginalValues(String parentPropertyName, O_DATOS_AUD complexObject, ObjectChangeTracker changeTracker)
        {
            if (String.IsNullOrEmpty(parentPropertyName))
            {
                throw new ArgumentException("El parámetro de cadena no puede ser NULL ni estar vacío.", "parentPropertyName");
            }
    
            if (changeTracker == null)
            {
                throw new ArgumentNullException("changeTracker");
            }
            changeTracker.RecordOriginalValue(String.Format(CultureInfo.InvariantCulture, "{0}.APP_ID_USUARIO", parentPropertyName), complexObject == null ? null : (object)complexObject.APP_ID_USUARIO);
            changeTracker.RecordOriginalValue(String.Format(CultureInfo.InvariantCulture, "{0}.AUD_ESTADO", parentPropertyName), complexObject == null ? null : (object)complexObject.AUD_ESTADO);
            changeTracker.RecordOriginalValue(String.Format(CultureInfo.InvariantCulture, "{0}.FECHA_REGISTRO", parentPropertyName), complexObject == null ? null : (object)complexObject.FECHA_REGISTRO);
        }

        #endregion

    }
}

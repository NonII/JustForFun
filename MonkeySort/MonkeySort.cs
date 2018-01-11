﻿using System;

namespace MonkeySort {
    public class MonkeySort<T> {
        private Func<T, T, bool> judge;

        public MonkeySort ( Func<T, T, bool> judge_func ) => judge = judge_func;

        public void Sort ( ref T [] data ) {
            if ( data == null ) {
                throw new ArgumentNullException ( );
            }

            var rnd = new Random ( );
            while ( IsDataSorted ( data ) == false ) {
                _SwitchDataItem ( ref data, rnd.Next ( 0, data.Length ), rnd.Next ( 0, data.Length ) );
            }
        }

        public bool IsDataSorted ( T [] data ) {
            if ( data == null ) {
                throw new ArgumentNullException ( );
            }
            if ( data.Length <= 1 ) {
                return true;
            }

            for ( var i = 1; i < data.Length; i++ ) {
                if ( judge ( data [i - 1], data [i] ) == false ) {
                    return false;
                }
            }
            return true;
        }

        private void _SwitchDataItem ( ref T [] data, int i, int j ) {
            if ( data == null ) {
                throw new ArgumentNullException ( );
            }
            if ( i < 0 || j < 0 || i >= data.Length || j >= data.Length ) {
                throw new ArgumentException ( );
            }
            if ( i == j ) {
                return;
            }

            var tmp = data [i];
            data [i] = data [j];
            data [j] = tmp;
        }
    }
}

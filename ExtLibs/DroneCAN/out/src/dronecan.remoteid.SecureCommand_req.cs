
using uint8_t = System.Byte;
using uint16_t = System.UInt16;
using uint32_t = System.UInt32;
using uint64_t = System.UInt64;

using int8_t = System.SByte;
using int16_t = System.Int16;
using int32_t = System.Int32;
using int64_t = System.Int64;

using float32 = System.Single;

using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace DroneCAN
{
    public partial class DroneCAN {
        static void encode_dronecan_remoteid_SecureCommand_req(dronecan_remoteid_SecureCommand_req msg, dronecan_serializer_chunk_cb_ptr_t chunk_cb, object ctx) {
            uint8_t[] buffer = new uint8_t[8];
            _encode_dronecan_remoteid_SecureCommand_req(buffer, msg, chunk_cb, ctx, true);
        }

        static uint32_t decode_dronecan_remoteid_SecureCommand_req(CanardRxTransfer transfer, dronecan_remoteid_SecureCommand_req msg) {
            uint32_t bit_ofs = 0;
            _decode_dronecan_remoteid_SecureCommand_req(transfer, ref bit_ofs, msg, true);
            return (bit_ofs+7)/8;
        }

        static void _encode_dronecan_remoteid_SecureCommand_req(uint8_t[] buffer, dronecan_remoteid_SecureCommand_req msg, dronecan_serializer_chunk_cb_ptr_t chunk_cb, object ctx, bool tao) {
            memset(buffer,0,8);
            canardEncodeScalar(buffer, 0, 32, msg.sequence);
            chunk_cb(buffer, 32, ctx);
            memset(buffer,0,8);
            canardEncodeScalar(buffer, 0, 32, msg.operation);
            chunk_cb(buffer, 32, ctx);
            memset(buffer,0,8);
            canardEncodeScalar(buffer, 0, 8, msg.sig_length);
            chunk_cb(buffer, 8, ctx);
            if (!tao) {
                memset(buffer,0,8);
                canardEncodeScalar(buffer, 0, 8, msg.data_len);
                chunk_cb(buffer, 8, ctx);
            }
            for (int i=0; i < msg.data_len; i++) {
                    memset(buffer,0,8);
                    canardEncodeScalar(buffer, 0, 8, msg.data[i]);
                    chunk_cb(buffer, 8, ctx);
            }
        }

        static void _decode_dronecan_remoteid_SecureCommand_req(CanardRxTransfer transfer,ref uint32_t bit_ofs, dronecan_remoteid_SecureCommand_req msg, bool tao) {

            canardDecodeScalar(transfer, bit_ofs, 32, false, ref msg.sequence);
            bit_ofs += 32;

            canardDecodeScalar(transfer, bit_ofs, 32, false, ref msg.operation);
            bit_ofs += 32;

            canardDecodeScalar(transfer, bit_ofs, 8, false, ref msg.sig_length);
            bit_ofs += 8;

            if (!tao) {
                canardDecodeScalar(transfer, bit_ofs, 8, false, ref msg.data_len);
                bit_ofs += 8;
            } else {
                msg.data_len = (uint8_t)(((transfer.payload_len*8)-bit_ofs)/8);
            }

            msg.data = new uint8_t[msg.data_len];
            for (int i=0; i < msg.data_len; i++) {
                canardDecodeScalar(transfer, bit_ofs, 8, false, ref msg.data[i]);
                bit_ofs += 8;
            }

        }
    }
}
import { Injectable } from '@angular/core';
import { ApiService } from './api.services';
import { Pedido } from '../models/pedido.model';
import { Observable } from 'rxjs';

import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class PedidoService extends ApiService {
   private apiUrl = 'https://localhost:44365/Dados';



  listarPedidos(status?: string): Observable<Pedido[]> {
    const query = status ? `pedidos?status=${status}` : 'Pedidos';
    return this.get<Pedido[]>(query);
  }

  criarPedido(pedido: Pedido): Observable<Pedido> {
    return this.post<Pedido>('Pedidos', pedido);
  }

  // atualizarStatus(id: number, status: string) {
  //   return this.http.patch(`Pedidos/${id}/status`, { status });
  // }
  atualizarStatus(id: number, status: string) {
  const headers = new HttpHeaders({ 'Content-Type': 'application/json' });
  console.log('teste' + status)
  return this.patch(
    `Pedidos/${id}/status`,
    JSON.stringify(status), // envia uma string JSON, não objeto
    { headers }
  );
 }

}

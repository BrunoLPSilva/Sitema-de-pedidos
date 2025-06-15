import { Component, Input } from '@angular/core';
import { Pedido } from 'src/app/core/models/pedido.model';
import { PedidoService } from 'src/app/core/services/pedido.service';

@Component({
  selector: 'app-listar-pedidos',
  templateUrl: './listar-pedidos.component.html',
  styleUrls: ['./listar-pedidos.component.scss']
})
export class ListarPedidosComponent {
 pedidos: Pedido[] = [];

  constructor(private pedidoService: PedidoService) {}

  ngOnInit() {
    this.pedidoService.listarPedidos().subscribe(data => this.pedidos = data);
  }



}

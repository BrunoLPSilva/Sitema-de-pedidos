import { ActivatedRoute, Route, Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { PedidoService } from 'src/app/core/services/pedido.service';

@Component({
  selector: 'app-atualizar-status',
  templateUrl: './atualizar-status.component.html',
  styleUrls: ['./atualizar-status.component.scss']
})
export class AtualizarStatusComponent implements OnInit {
  idPedido!: number;
  novoStatus: string = 'Pendente';

  pedido: any = {};

  constructor(
    private route: ActivatedRoute,
    private pedidoService: PedidoService,
    private router: Router
  ) {}

  ngOnInit(): void {

    this.idPedido = Number(this.route.snapshot.paramMap.get('id'));
  }

  voltarParaHome(): void {
  this.router.navigate(['']);
            }



  atualizarStatus(): void {
    console.log('teste:', this.novoStatus);
    this.pedidoService.atualizarStatus(this.idPedido, this.novoStatus)
      .subscribe({
        next: () => {
          alert('Status atualizado com sucesso!');
          this.router.navigate(['']);  // navega só depois do sucesso
        },
        error: err => console.error('Erro ao atualizar:', err)
      });
  }
}

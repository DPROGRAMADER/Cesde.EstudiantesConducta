import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { conductaEstudiante } from '../models/conductaEstudiante';
import { Observable, } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ConductaEstudianteService {

  urlApi: string = ""

  constructor(private http: HttpClient) {
    this.urlApi = `${environment.baseUrlApi}/ EstudianteController`
  }

  postEstudianteController(from: conductaEstudiante): Observable<conductaEstudiante> {
    return this.http.post<conductaEstudiante>(`${this.urlApi}/CrearConductaEstudiante`, from)
  }
  putEstudianteController(from: conductaEstudiante): Observable<conductaEstudiante> {
    return this.http.put<conductaEstudiante>(`${this.urlApi}/EditarConductaEstudiante`, from)
  }
  deleteEstudianteController(id: number): Observable<any> {
    return this.http.delete<conductaEstudiante>(`${this.urlApi}/EliminarConductaEstudiante/${id}`,)
  }
  getEstudianteController(): Observable<conductaEstudiante[]> {
    return this.http.get<conductaEstudiante[]>(`${this.urlApi}/ConsultarConductasEstudiantes`)
  }
}

(* ::Package:: *)

(* Creates a random graph to make an image. *)


ClearAll["Global`*"]
SetDirectory[NotebookDirectory[]];


g = RandomGraph[
	{200,400}, 
	EdgeStyle->Gray, 
	VertexStyle->Gray, 
	VertexShapeFunction->"Circle",
	VertexSize->Large
]
Show[g, Background->LightBlue, ImageSize->{{1900}, {1900}}]
ImageCrop[%, {1800, 400}]
Export["graph.png", %]


(* End *)

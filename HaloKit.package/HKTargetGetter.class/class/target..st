accessing
target: evt
	^(evt hand ifNil: [ ActiveHand ]) objectUnder ifCanvas: [:c|self target: c haloAPI activeEvent  ]